using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrensGame
{
    public class Game
    {
        public void Run()
        {
            var numberOfChildren = 3;

            // set up children - Dictionary<int, int> children = new Dictionary<int, int>();
            Dictionary<int, int> children = new Dictionary<int, int>();

            // add children to dictionary
            for (var i = 1; i <= numberOfChildren; i++)
            {
                var index = i;
                children.Add(index, i);
                //Console.WriteLine("Id = " + (i));
            }

            // set up variable for number to use for elimination
            var numberToUse = 2;

            // set up variable for index of child to eliminate      
            var indexToEliminate = 0; // set to 0 to start
            // use numberToUse to count through dictionary
            // set value of indexToEliminate to the child to eliminate
            indexToEliminate = numberToUse % children.Count;

            // add children.id to a list
            var orderOfElimination = new List<int>();
            // add eliminated child's id to list
            orderOfElimination.Add(children[indexToEliminate]);
            Console.WriteLine(string.Join(", ", orderOfElimination));
            // eliminate child at indexToEliminate from dictionary
            children.Remove(indexToEliminate);
            //// write out children   
            //foreach (KeyValuePair<int, int> kvp in children)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}",
            //        kvp.Key, kvp.Value);
            //}

            //Console.WriteLine(string.Join(", ", orderOfElimination));
            // child.id == new 1st index of dictionary (reorder dictionary??)

            // order_of_elimination using numberToUse == {1, 0}
            // winner = children[0] (should be id 2)
        }
    }
}