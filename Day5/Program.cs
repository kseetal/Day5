#region Part 1

//public class Day5
//{
//    public static void Main()
//    {


//        var boxes = new List<string>();
//        var instructions = new List<string>();
//        string line;
//        int noOfStacks = 0;
//        var stack1 = new Stack<string>();
//        var stack2 = new Stack<string>();
//        var stack3 = new Stack<string>();
//        var stack4 = new Stack<string>();
//        var stack5 = new Stack<string>();
//        var stack6 = new Stack<string>();
//        var stack7 = new Stack<string>();
//        var stack8 = new Stack<string>();
//        var stack9 = new Stack<string>();
//        var stacksDict = new Dictionary<int, Stack<string>> {
//            {1, stack1 },
//            {2, stack2 },
//            {3, stack3 },
//            {4, stack4 },
//            {5, stack5 },
//            {6, stack6 },
//            {7, stack7 },
//            {8, stack8 },
//            {9, stack9 }
//        };

//        #region Read input

//        while ((line = Console.ReadLine()) != string.Empty)
//        {
//            boxes.Add(line);
//        }

//        line = boxes.Last();
//        for (int i=0; i< line.Length; i++)
//        {
//            if (line[i] != ' ')
//            {
//                noOfStacks++;
//            }
//        }

//        var stacks = new string[noOfStacks][];
//        while ((line = Console.ReadLine()) != string.Empty)
//        {
//            instructions.Add(line);
//        }

//        for (int j = boxes.Count - 2; j >= 0; j--)
//        {
//            for (int i = 0; i < boxes[j].Length; i++)
//            {
//                if (!char.IsWhiteSpace(boxes[j][i]) && boxes[j][i] != '[' && boxes[j][i] != ']')
//                {
//                    switch (i) {
//                    case 1:
//                        stack1.Push(boxes[j][i].ToString());
//                            break;
//                    case 5:
//                        stack2.Push(boxes[j][i].ToString());
//                            break;
//                    case 9:
//                        stack3.Push(boxes[j][i].ToString());
//                            break;
//                    case 13:                  
//                        stack4.Push(boxes[j][i].ToString());
//                            break;
//                    case 17:                    
//                        stack5.Push(boxes[j][i].ToString());
//                            break;
//                    case 21:                   
//                        stack6.Push(boxes[j][i].ToString());
//                            break;
//                    case 25:                   
//                        stack7.Push(boxes[j][i].ToString());
//                            break;
//                    case 29:                   
//                        stack8.Push(boxes[j][i].ToString());
//                            break;
//                    case 33:                  
//                        stack9.Push(boxes[j][i].ToString());
//                            break;

//                    default: break;
//                    }
//                }
//            }
//        }

//        #endregion

//        #region Do instructions

//        foreach (string instruction in instructions)
//        {
//            string[] tokens;

//            tokens = instruction.Split(' ');
//            int noBoxesMoved = int.Parse(tokens[1]);
//            int movedFrom = int.Parse(tokens[3]);
//            int movedTo = int.Parse(tokens[5]);

//            for (int i=0; i<noBoxesMoved; i++)
//            {
//                string temp = stacksDict[movedFrom].Pop();
//                stacksDict[movedTo].Push(temp);
//            }
//        }

//        string output = "";
//        foreach (Stack<string> stack in stacksDict.Values)
//        {
//            output += stack.Pop();
//        }

//        Console.WriteLine(output);
//        #endregion
//    }
//}

#endregion

#region Part 2

public class Day5
{
    public static void Main()
    {


        var boxes = new List<string>();
        var instructions = new List<string>();
        string line;
        int noOfStacks = 0;
        var stack1 = new Stack<string>();
        var stack2 = new Stack<string>();
        var stack3 = new Stack<string>();
        var stack4 = new Stack<string>();
        var stack5 = new Stack<string>();
        var stack6 = new Stack<string>();
        var stack7 = new Stack<string>();
        var stack8 = new Stack<string>();
        var stack9 = new Stack<string>();
        var stacksDict = new Dictionary<int, Stack<string>> {
            {1, stack1 },
            {2, stack2 },
            {3, stack3 },
            {4, stack4 },
            {5, stack5 },
            {6, stack6 },
            {7, stack7 },
            {8, stack8 },
            {9, stack9 }
        };

        #region Read input

        while ((line = Console.ReadLine()) != string.Empty)
        {
            boxes.Add(line);
        }

        line = boxes.Last();
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] != ' ')
            {
                noOfStacks++;
            }
        }

        var stacks = new string[noOfStacks][];
        while ((line = Console.ReadLine()) != string.Empty)
        {
            instructions.Add(line);
        }

        for (int j = boxes.Count - 2; j >= 0; j--)
        {
            for (int i = 0; i < boxes[j].Length; i++)
            {
                if (!char.IsWhiteSpace(boxes[j][i]) && boxes[j][i] != '[' && boxes[j][i] != ']')
                {
                    switch (i)
                    {
                        case 1:
                            stack1.Push(boxes[j][i].ToString());
                            break;
                        case 5:
                            stack2.Push(boxes[j][i].ToString());
                            break;
                        case 9:
                            stack3.Push(boxes[j][i].ToString());
                            break;
                        case 13:
                            stack4.Push(boxes[j][i].ToString());
                            break;
                        case 17:
                            stack5.Push(boxes[j][i].ToString());
                            break;
                        case 21:
                            stack6.Push(boxes[j][i].ToString());
                            break;
                        case 25:
                            stack7.Push(boxes[j][i].ToString());
                            break;
                        case 29:
                            stack8.Push(boxes[j][i].ToString());
                            break;
                        case 33:
                            stack9.Push(boxes[j][i].ToString());
                            break;

                        default: break;
                    }
                }
            }
        }

        #endregion

        #region Do instructions

        foreach (string instruction in instructions)
        {
            string[] tokens;

            tokens = instruction.Split(' ');
            int noBoxesMoved = int.Parse(tokens[1]);
            int movedFrom = int.Parse(tokens[3]);
            int movedTo = int.Parse(tokens[5]);
            var temp = new List<string>();

            for (int i = 0; i < noBoxesMoved; i++)
            {
                temp.Add(stacksDict[movedFrom].Pop());
            }

            temp.Reverse();
            foreach (string temp2 in  temp)
            {
                stacksDict[movedTo].Push(temp2);
            }
        }

        string output = "";
        foreach (Stack<string> stack in stacksDict.Values)
        {
            output += stack.Pop();
        }

        Console.WriteLine(output);
        #endregion
    }
}

#endregion