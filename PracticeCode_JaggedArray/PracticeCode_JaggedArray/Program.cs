using System;

namespace PracticeCode_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 5, 8, 9 };
            jaggedArray[1] = new int[] { 5, 8, 9,19 };
            jaggedArray[2] = new int[] { 5, 8, 9 ,8,10};
            jaggedArray[3] = new int[] { 5, 8, 9 };

            // for(int i = 0; i < jaggedArray.Length; i++)
            //{
            //  Console.WriteLine("the {0} array is : ",i+1);
            //for(int j = 0; j < jaggedArray[i].Length; j++)
            //{
            //    Console.WriteLine(jaggedArray[i][j]);
            //}
            //}
            //array_practice obj = new array_practice();
            //obj.arraylist();
            VideoPost video = new VideoPost("http/video.com", 10);
            video.play();
            Console.ReadKey();
            video.stop();
            Console.ReadLine();
           
        }
    }
}
