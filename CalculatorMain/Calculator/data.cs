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
    class data
    {
        private List<string> calculation = new List<string>(); //Used to create and compress math functions
        private string prevAns = "0"; //Holds most recent calculation
        private int index = 0;//Controls the position in the list calculation
        public data(){}
        public data(data copy,int min,int max) //Used for breaking down parts of a function for simpler math compression
        {
            for(int count = min; count <= max; count++)
                calculation.Add(copy.getData(count));
        }
        //assessors
        public int getLength() { return calculation.Count; } //Returns amount of indexes of list
        public string getData(int index) { return calculation[index]; } //Returns the data of a certian index
        public string getText() //returns entire data list as one string
        {
            string text = "";
            for (int count = 0; count < calculation.Count; count++)
            {
                text += calculation[count];
            }
            return text;
        }
        public string getLastAns() { return prevAns; }
        //Mutators
        //Used for mutating values during a function compression VV
        public void changeIndexVal(int index,string value){calculation[index] = value;}
        //Used to remove empty slots during compression VV
        public void removeIndex(int index) { calculation.RemoveAt(index);}
        public void removeLastIndex() //used to undo last input
        {
            if (calculation.Count > 0) //If there is anything to delete then begin deletion
            {
                calculation.RemoveAt(getLength() - 1);
                if (calculation.Count == 0)
                    index = 0;
                if (!isNum(getLength() - 1))
                    index = calculation.Count;//If prev index is a string and not a num go after it
                else
                    index = calculation.Count - 1; //If prev index is a num, go ontop of it to allow alteration to that num
            }
        }
        public void updateLastAns(double ans) { prevAns = Convert.ToString(ans); }
        public void addData(string var) // adds to a list/expands an element
        {
            getText();
            try
            {
                Convert.ToInt64(var); //Checks if it is possible to convert to int, if not then form enters an op
                if(calculation.Count == index)  //Checks if said number is the start of the string             
                    calculation.Add(var);                
                else //Adds onto a number string
                    calculation[index] += var;
            }
            catch // All Operators, decimal, and negative signs go here
            {
                if (var == ".") //Decimal data stays with integer strings
                {
                    if (isNum(index)) //Sets the beginning of the decimal
                        calculation[index] += var;
                    else //used to start a number with a decimal i.e, .65
                        calculation.Add(var);
                }
                else if(var == "(" || var == ")")
                {//Parenthesis are always at the beginning, end, or after an operator in this format therefore only one index is moved
                    calculation.Add(var);
                    index++;
                }
                else // adds Operators
                {
                    if(calculation.Count == 0)//If an Op is used with an index of 0 then assume an operation with                 
                        calculation.Add(prevAns); //Previous calc, if first calculation then 0 will be used                            
                    calculation.Add(var);
                    index += 2; //Index moves to Operator slot then over one to prepare for a new string
                } 
            }
        }
        public void negativeOp() //Operations for negation
        {
            getText();//DEBUG CODE
            if (calculation.Count == index) //If no input is inside a selected index start with -
                calculation.Add("-");
            else if (calculation[index] == "-") // turn a single - to +
                calculation[index] = "";
            else if (isNum(index))
            {
                if (Convert.ToDouble(calculation[index]) >= 0) //Inputs a - to the beginning of index
                {
                    string hold = "-";
                    hold += calculation[index];
                    calculation[index] = hold;
                }
                else //Converts a - to a + to the beginning of index
                {
                    double num = Convert.ToDouble(calculation[index]);
                    num *= -1;
                    calculation[index] = Convert.ToString(num);
                }
            }
            else
            {
                calculation[index] = "-" + calculation[index];
            }

        }
        //Misc
        public void clear() // Deletes entire list of calculation 
        {
              for(int count = calculation.Count-1; count >= 0; count--)
              {
                  calculation.RemoveAt(count);
              }
              index = 0; //Resets index
        }
        public bool isNum(int index) //Used to differentiate between numbers and math operators
        {
            try
            {
                Convert.ToDouble(calculation[index]);
            }
            catch { return false; }
            return true;
        }
        public void deleteList() //Deletes a list completely; used for destruction of a copy variable
        {
            for (int count = 0; count < calculation.Count; count++)
                calculation.RemoveAt(0);
        }
    }
}
