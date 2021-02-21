using System;
using System.Collections.Generic;

namespace EightPuzzle
{
    class Node
    {
        public List<Node> children = new List<Node>();
        public Node parent;
        public int[] puzzle = new int[9];
        public int x = 0;
        public int col = 3; // column

        public Node(int[] p){
            setPuzzle(p);
        }
        public void setPuzzle(int[] p){
            for(int i = 0; i < puzzle.Length; i++){
                this.puzzle[i] = p[i];
            }
        }
        public void ExpandNode(){
            for(int i=0; i<puzzle.Length; i++){
                if(puzzle[i] == 0){
                    x = i;
                }
            }
            MoveToRight(puzzle,x);
            MoveToLeft(puzzle,x);
            MoveToUp(puzzle,x);
            MoveToDown(puzzle,x);
        }
        public void MoveToRight(int[] p, int i){
            if(i % col < col - 1){
                int[] pc = new int[9];
                CopyPuzzle(pc,p);

                int temp = pc[i+1];
                pc[i+1] = pc[i];
                pc[i] = temp;

                Node child = new Node(pc);
                children.Add(child);
                child.parent = this;
            }
        }
        public void MoveToLeft(int[] p, int i){
            if(i % col > 0){
                int[] pc = new int[9];
                CopyPuzzle(pc,p);

                int temp = pc[i-1];
                pc[i-1] = pc[i];
                pc[i] = temp;
                
                Node child = new Node(pc);
                children.Add(child);
                child.parent = this;
            }
        }
        public void MoveToUp(int[] p, int i){
            if(i - col >= 0){
                int[] pc = new int[9];
                CopyPuzzle(pc,p);

                int temp = pc[i-3];
                pc[i-3] = pc[i];
                pc[i] = temp;

                Node child = new Node(pc);
                children.Add(child);
                child.parent = this;
            }
        }
        public void MoveToDown(int[] p, int i){
            if(i + col < puzzle.Length){
                int[] pc = new int[9];
                CopyPuzzle(pc,p);

                int temp = pc[i+3];
                pc[i+3] = pc[i];
                pc[i] = temp;

                Node child = new Node(pc);
                children.Add(child);
                child.parent = this;
            }
        }
        public void PrintPuzzle(){
            Console.WriteLine();
            int m = 0;
            for(int i=0;i<col;i++){
                for(int j = 0; j < col; j++){
                    Console.Write(puzzle[m]+" ");
                    m++;
                }
                Console.WriteLine();
            }
        }
        public bool IsSamePuzzle(int[] p){
            bool samePuzzle = true;
            for(int i=0; i<p.Length; i++){
                if(puzzle[i] != p[i]){
                    samePuzzle = false;
                }
            }
            return samePuzzle;
        }
        public void CopyPuzzle(int[] a,int[] b){
            for(int i = 0; i<b.Length; i++){
                a[i] = b[i];
            }
        }
        public bool GoalTest(){
            bool isGoal = true;
            int m = puzzle[0];

            for(int i = 1; i < puzzle.Length; i++){
                if(m > puzzle[i]){
                    isGoal = false;
                }
                m = puzzle[i];
            }
            return isGoal;

        }
    }
}