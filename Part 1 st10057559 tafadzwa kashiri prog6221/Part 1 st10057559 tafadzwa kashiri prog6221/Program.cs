using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    
    class Ingredient
    {
        public String Name { get; set; }
        public double Quantity { get; set; }
        public double OriginalQuantity { get; set; }
        public String Unit { get; set; }

        //Constructor for ingriedient
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            OriginalQuantity = quantity;


        }
        //Venkat Marisetty
        //https:youtu.be/5kf_HXf1JgQ
        //class recipe with ArrayLists
        class Recipe
        {
            //Storing ingredients and steps
            private List<Ingredient> ingredients;
            private List<string> steps;
            private double scale;

            public Recipe()
            {
                ingredients = new List<Ingredient>();
                steps = new List<string>();
                scale = 1.0;

            }
            // Methods
            public void EnterDetails()
            {
                //Adapted from Dani Krosing
                //https://youtu.be/fZioOGu6DlI
                //prompt the user to enter the number of ingredients
                Console.WriteLine("Enter the number of ingredients");
                int numIngredient = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numIngredient; i++)
                {

                    Console.WriteLine("*****The Ingredients Details*****");
                    Console.Write("Please enter Ingredient name {0} : ", i + 1);
                    String name = Console.ReadLine();
                    Console.Write("Please enter the quantity {0} :", i + 1);
                    double quantity = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the unit of measurement {0} :", i + 1);
                    String Unit = Console.ReadLine();
                    ingredients.Add(new Ingredient(name, quantity, Unit));
                }
                //prompt the user to enter the steps
                Console.WriteLine("Enter the number of steps: ");
                int numSteps = int.Parse(Console.ReadLine());
                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine("Enter step {0} :", i + 1);
                    string step = Console.ReadLine();
                    steps.Add(step);
                    
                    

                }
            }
            //Adapted from Gamaliel Menil
            //https://youtu.be/az8mHaJXpRE
            public void DisplayRecipe()
            {
                //display the ingredients and quantities
                Console.WriteLine("Recipe displayed below:");
                foreach (Ingredient ingredient in ingredients)
                {
                    Console.WriteLine("{0} {1} of {2}", ingredient.Quantity * scale, ingredient.Unit, ingredient.Name);
                }
                //display the steps
                Console.WriteLine("\nSteps:");
                for (int i = 0; i < steps.Count; i++)
                {
                    Console.WriteLine("{0}.{1}", i + 1, steps[i]);
                }

                }
                //scaling the recipe
                public void ScaleRecipe()
                {
                Console.WriteLine("Enter a scaling factor(0.5,2 or 3 :");
                Double factor = double.Parse(Console.ReadLine());
                if (factor == 0.5 || factor == 2 || factor == 3)
                {
                    scale = factor;
                }
                else
                {
                    Console.WriteLine("Invalid scale factor");
                }

                    
                    }
                    public void ResetQuantities()
                {
                    //reset all the quantities to their original value
                    scale = 1.0;
            foreach (var ingredient in ingredients)
                ingredient.Quantity = ingredient.OriginalQuantity;
                Console.WriteLine("Quantities have been successfully reset!");
                }
                    
                    public void ClearRecipe()
                    {
                        //clear the recipe
                        ingredients.Clear();
                        steps.Clear();
                        scale = 1.0;
                    }

                    }

            internal class Program
            {
            //Adapted from Bro Code
            //https://youtu.be/Qu93CRt-FGc

            static void Main(string[] args)
                {
                    Recipe recipe = new Recipe();
                bool running = true;
                    while (running)
                    {
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("   Enter your Choice (1-6) ");
                        Console.WriteLine("Enter '1' to enter recipe details");
                        Console.WriteLine("Enter '2' to Display recipe");
                        Console.WriteLine("Enter '3' to Scale recipe");
                        Console.WriteLine("Enter '4' to Reset Quantities");
                        Console.WriteLine("Enter '5' to Clear recipe");
                        Console.WriteLine("Enter '6' to Exit Program");
                        Console.WriteLine("------------------------------------");

                        String input = Console.ReadLine() ;
                        switch (input)
                        {
                                //calling the methods
                            case "1":
                                recipe.EnterDetails();
                                break;
                            case "2":
                                recipe.DisplayRecipe();
                                break;
                            case "3":
                           
                                recipe.ScaleRecipe();
                            break;
                            case "4":
                                recipe.ResetQuantities();
                                break;
                            case "5":
                            recipe.ClearRecipe();
                                break;
                            case "6":
                                return;
                            break;
                            default:
                                Console.WriteLine("Invalid command!"); break;


                        }
                        
                    }
                }
            }
        }
    }

                
            

        
    



               
            
        
    

