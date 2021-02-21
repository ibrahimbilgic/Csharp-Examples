using System;
using System.Collections.Generic;

namespace EightPuzzle
{
     /*
    
    Solve the puzzle with BFS
    initial state                Goal state

    -------------               -------------
    | 1 | 2 | 4 |               | 0 | 1 | 2 |
    -------------               -------------
    | 3 | 0 | 5 |    --->       | 3 | 4 | 5 |             
    -------------               -------------
    | 7 | 6 | 8 |               | 6 | 7 | 8 |
    -------------               -------------
    */
    
    class Program
    {
       
        static void Main(string[] args)
        {
            
            int[] puzzle = {
                1, 2, 4,
                3, 0, 5,
                7, 6, 8
            };

            Node root = new Node(puzzle);
            UninformedSearch ui = new UninformedSearch();

            List<Node> solution = ui.BreadthFirstSearch(root);

            if(solution.Count > 0){
                solution.Reverse();
                for(int i = 0; i < solution.Count; i++){
                    solution[i].PrintPuzzle();
                }
                
            }
            else
            {
                Console.WriteLine("No path to solution is found.");
            }
            //Console.Read();
                
        }
    }
}
