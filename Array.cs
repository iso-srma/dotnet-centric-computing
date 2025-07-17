// using System;

// class ArrayDemo
// {
//     static void Main()
//     {
//         ArrayDemo arr = new ArrayDemo();
//         arr.Learn1DArray();
//         arr.Learn2DAnd3DArray();
//         arr.LearnJaggedArray();
//     }

//     void Learn1DArray()
//     {
//         int[] ages1 = new int[10];
//         double[] ages2 = new double[10];

//         ages1[0] = 37;
//         ages2[5] = 4;

//         float[] number1 = new float[] { 24f, 4f, 45f, 6f, 12f, 34f };
//         float[] number2 = { 24f, 4f, 45f, 6f, 12f, 34f };
//     }

//     void Learn2DAnd3DArray()
//     {
//         // 2D array
//         int[,] agesMatrix = new int[10, 15]; // corrected syntax
//         agesMatrix[0, 0] = 4567;

//         // 3D array
//         int[,,] agesMatrix3D = new int[10, 15, 6]; // corrected syntax

//         // Initializing a 2D string array
//         string[,] names = new string[,]
//         {
//             { "ishwor", "suvash" },
//             { "rahul", "sabin" }
//         };
//     }

//     void LearnJaggedArray()
//     {
//         byte[][] personAges = new byte[4][]; // changed from 3 to 4 because index 3 was being accessed
//         personAges[0] = new byte[2] { 34, 56 };
//         personAges[1] = new byte[] { 34, 56, 23, 45, 67 };
//         personAges[2] = new byte[] { 34, 56, 23, 45 };
//         personAges[3] = new byte[] { 34, 56, 23, 45, 80 };
//     }
// }
