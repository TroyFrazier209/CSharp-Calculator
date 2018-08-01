/*Author:Troy Frazier
7/5/2017
*/
/*
MIT License

Copyright (c) 2018 Troy Frazier

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form 
    {
        data function = new data(); //Class that holds a math function of some kind
        public Calc()
        {
            InitializeComponent();
        }
        //Math methods
        private bool verification(data pMath) //verifies user Syntax
        {
            int pStart = 0;
            pMath.getText();//DEBUG CODE
            if (pMath.getText() != "") //If calc is not an empty set begin verification
            {
                if (pMath.getLength() % 2 != 1) //A fully formed function will always have a odd index; 2+2 = index 3 
                {
                    _calcDisplay.Text = "Syntax Error";
                    return false;
                }
                for (int count = 0; count < pMath.getLength(); count += 2)
                {
                    if (pMath.getData(count) == "(") //Finds everything between a (...) and starts verification over
                    {
                        pStart = count;
                        count = pChec(count, pMath);
                        if(count == pMath.getLength())
                        {
                            _calcDisplay.Text = "Syntax Error";
                            return false;
                        }
                        else
                        {
                            data paren = new data(pMath, pStart + 1, count - 1);
                            if (!verification(paren))
                            {
                                _calcDisplay.Text = "Syntax Error";
                                return false;
                            }
                            //count++; To remove after review
                        }
                    }
                    //Moves count by one and check if that is a number                   
                    else if (!pMath.isNum(count))
                    {
                        _calcDisplay.Text = "Syntax Error";
                        return false;
                    }

                }
            }
            else
            {
                _calcDisplay.Text = "No data entered...";
                return false;
            }
            return true;
        }
        private int pChec(int count, data pMath)
        {
            List<bool> pFlags = new List<bool>(); //In the case of mutiple () i.e f(x) = (((((((5)))))))
            count++; //Beginning of method will contain a ( ++ to elminate that factor
            while (count != pMath.getLength())
            {
                if (pMath.getData(count) == "(")
                    pFlags.Add(true);
                else if (pMath.getData(count) == ")" && pFlags.Count > 0)
                {
                    pFlags.RemoveAt(0);
                    // count++;
                }
                else if (pFlags.Count == 0 && pMath.getData(count) == ")")
                    return count; //Returns a successful ( ) 
                count++;
            }
            return count;
        }
        private void math(data pMath,List<int> opCoords)
        { //Data pMath is used in the case of recursive during pBounds
            bool addFlag = false; //Used to control the mutation of a subtraction sign
            pBounds(pMath,opCoords);//P
           pMath.getText(); //DEBUG CODE
            scanOps("^", opCoords,pMath);
            if (opCoords.Count != 0) // if opcoords == 0 then no op of said type was found
                compress('^', opCoords, pMath);
            scanOps("/", opCoords, pMath);//D overides M more for a fractional ideology then a whole number compression
            if (opCoords.Count != 0)
                compress('/', opCoords, pMath);
            scanOps("*", opCoords,pMath);//M
            if (opCoords.Count != 0)
                compress('*', opCoords, pMath);
            do
            { //In the case a compression converts a subtraction into an addition repeat A process
                scanOps("+", opCoords, pMath);//A
                if (opCoords.Count != 0)
                    addFlag = compress('+', opCoords, pMath);
            } while (addFlag);
            scanOps("-", opCoords, pMath);//S
            if (opCoords.Count != 0)
                compress('-', opCoords, pMath);

        }//Beginning math method that holds Order of Operations
        private void pBounds(data pMath, List<int> opCoords)
        {
            //pMath.getText();//DEBUG CODE
            bool endP = false;//flag when the correct ( ) pair is found
            List<bool> pFlags = new List<bool>(); //In the case of mutiple () i.e f(x) = (((((((5)))))))
            int max = 0; //Holds the index that has ( to start the bounds
            for(int count = pMath.getLength()-1; count >= 0; count--)
            {
                if (pMath.getData(count) == ")")
                { //Finds last part of bound aka "max"
                    max = count;
                    while (!endP)
                    {
                        count--;
                        if (pMath.getData(count) == ")")
                            pFlags.Add(true); //if there is another ) then the next ( is not the true partner
                        else if (pFlags.Count > 0 && pMath.getData(count) == "(")
                        {
                            pFlags.RemoveAt(0); //Remove a bool, the specific bool doesnt matter
                        }
                        else if (pFlags.Count == 0 && pMath.getData(count) == "(")
                            endP = true;//If no other ) found then selected ( is the true partner
                    }
                    endP = false;
                    data boundMath = new data(pMath, count + 1, max - 1); //Creates a function of the math inside ()
                    math(boundMath, opCoords); //Starts over math method and compresses boundMath to 1 length
                    pMath.changeIndexVal(count, boundMath.getData(0)); //turns the "(" into answer
                    for (int subCount = max; subCount > count; subCount--) //Removes everything up to ")"
                        pMath.removeIndex(subCount); //Keeps index at 1 since removing moves all indexes by -1
                    boundMath.deleteList();//Destroys dynamically allocated memory
                    boundMath = null;
                }

            }
        }//Function used to single out (..math..)
        private void scanOps(string op,List<int> coords, data pMath) //pMath used in the case of parentheses for recursive
        {
            for(int count = 0; count < pMath.getLength(); count++)
            {
                if (pMath.getData(count) == op)
                {
                    coords.Add(count - 1);
                    coords.Add(count + 1);
                }
            }
        }
        private bool compress(char op, List<int> coords, data pMath)
        {
            bool addFlag = false; //In the case of a subtraction converting to addition
            double value;
            for(int count = coords.Count-1; count > 0; count -=2)//For every pair of Max and Min coords, compress
            {
                /* ***If Statment Explanation*** 
                    If the Min index (left side operation) is not the first of the function then check
                    the operator before it and see if it is a -, if it, turn the number into its negative component
                    Compress and take the abs value to ensure the subtraction is still in effect
                    otherwise just compress normally*/
                if (op != '^' &&coords[count - 1] != 0 && pMath.getData(coords[count - 1] - 1) == "-")
                {//If a summation with a lefthand subtraction is true then convert whole number into a negative number
                //Exponent get a special case as only negative numbers squared should take signs into account i.e 1-(2)^2 = -3 where 1-2^2=5
                    value = mathify(op, Convert.ToDouble(pMath.getData(coords[count - 1])) * -1, Convert.ToDouble(pMath.getData(coords[count])));
                    if (value > 0)
                    {
                        pMath.changeIndexVal(coords[count - 1] - 1, "+");//If the left negative becomes a positive
                        addFlag = true;
                    }
                    value = Math.Abs(Convert.ToDouble(value)); //trade sign value for op value
                }
                //get left and right side of an op then get a value using said function. Compress and present -Ver
                else// ^ Positive ver.
                    value = mathify(op, Convert.ToDouble(pMath.getData(coords[count - 1])), Convert.ToDouble(pMath.getData(coords[count])));
                pMath.removeIndex(coords[count]); //Remove right side value
                pMath.removeIndex(coords[count] - 1); //Remove middle value aka Operator
                pMath.changeIndexVal(coords[count - 1], Convert.ToString(value)); //Changes the left side value
                coords.RemoveAt(count); //remove max coord index
                coords.RemoveAt(count - 1); //remove min coord index
            }
            return addFlag;
        }//Compresses math until just one element is left (Answer)
        private double mathify(char op,double left, double right)
        {
            switch (op)
            {
                case '*':
                    return left * right;
                case '/':
                    return left / right;
                case '+':
                    return left + right;
                case '^':
                    return Math.Pow(left, right);
                default:
                    return left - right;
            }
        }//Holds the acutal math functions
        //Form's events
        private void button13_Click(object sender, EventArgs e) //Equals button
        {
            List<int> opCoords = new List<int>();//Holds the min and max coords for a compression in that order
            function.getText();
            if (verification(function)) //If false an error message will appear automatically
            {
                math(function, opCoords); //Compression to 1 answer begins here
                _calcDisplay.Text = function.getText();
                function.updateLastAns(Convert.ToDouble(_calcDisplay.Text));
            }
                function.clear();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void _btn7_Click(object sender, EventArgs e)
        {
            function.addData("7");
            _calcDisplay.Text = function.getText();
        }
        private void _calcDisplay_TextChanged(object sender, EventArgs e)
        {
        }
        private void _btn8_Click(object sender, EventArgs e)
        {
            function.addData("8");
            _calcDisplay.Text = function.getText();

        }
        private void _btn9_Click(object sender, EventArgs e)
        {
            function.addData("9");
            _calcDisplay.Text = function.getText();

        }
        private void _btn4_Click(object sender, EventArgs e)
        {
            function.addData("4");
            _calcDisplay.Text = function.getText();
        }
        private void _btn5_Click(object sender, EventArgs e)
        {
            function.addData("5");
            _calcDisplay.Text = function.getText();

        }
        private void _btn6_Click(object sender, EventArgs e)
        {
            function.addData("6");
            _calcDisplay.Text = function.getText();

        }
        private void _btn1_Click(object sender, EventArgs e)
        {
            function.addData("1");
            _calcDisplay.Text = function.getText();

        }
        private void _btn2_Click(object sender, EventArgs e)
        {
            function.addData("2");
            _calcDisplay.Text = function.getText();

        }
        private void _btn3_Click(object sender, EventArgs e)
        {
            function.addData("3");
            _calcDisplay.Text = function.getText();

        }
        private void _btn0_Click(object sender, EventArgs e)
        {
            function.addData("0");
            _calcDisplay.Text = function.getText();

        }
        private void _btnDeci_Click(object sender, EventArgs e)
        {
            function.addData(".");
            _calcDisplay.Text = function.getText();

        }
        private void _btnNegative_Click(object sender, EventArgs e)
        {
            function.negativeOp();
            _calcDisplay.Text = function.getText();

        }
        private void button16_Click(object sender, EventArgs e) //Mutiplication button
        {
            function.addData("*");
            _calcDisplay.Text = function.getText();

        }
        private void _btnDiv_Click(object sender, EventArgs e)
        {
            function.addData("/");
            _calcDisplay.Text = function.getText();
        }
        private void _btnSub_Click(object sender, EventArgs e)
        {
            function.addData("-");
            _calcDisplay.Text = function.getText();

        }
        private void _btnPlus_Click(object sender, EventArgs e)
        {
            function.addData("+");
            _calcDisplay.Text = function.getText();

        }
        private void _btnClear_Click(object sender, EventArgs e)
        {
            function.clear();
            _calcDisplay.Text = function.getText();
            

        }
        private void _btnCP_Click(object sender, EventArgs e)
        {
            function.addData(")");
            _calcDisplay.Text = function.getText();

        }
        private void _btnOP_Click(object sender, EventArgs e)
        {
            function.addData("(");
            _calcDisplay.Text = function.getText();

        }
        private void _btnPow_Click(object sender, EventArgs e)
        {
            function.addData("^");
            _calcDisplay.Text = function.getText();
        }
        private void _author_Click(object sender, EventArgs e)
        {
        } //Author: Troy Frazier

        private void _DelBtn_Click(object sender, EventArgs e)
        {
            function.removeLastIndex();
            _calcDisplay.Text = function.getText();
        }
    }
}
