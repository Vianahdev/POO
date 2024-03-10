using System;
using System.Security.Cryptography.X509Certificates;

namespace CursoPOODotNet{
    class Program{
        static void Main(string[] args){
            var v_number = new Number();
            v_number.MyProperty = 2;

        }
    }

    class Number{
        private int myNumber;
        public int MyProperty
        {
            get { 
                return myNumber; 
            }

            set { 
                if(value == 2){
                    var number = value * 3;
                    Console.WriteLine(number);

                    myNumber = number;
                }
                else{
                    Console.WriteLine("Valor invalido");
                }
            }
        }
        
    }

    
}