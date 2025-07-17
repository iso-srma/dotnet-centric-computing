
class Array

{
    void Learn1DArray()
    {
        int[]ages1 =new int[10];
        double[]ages2 = new double[10];

        ages1[0] = 37;
        ages2[5] = 4;

        float[] number1 =new float[] { 24,4f,45,6f,12,34f};
        float[] number2 = { 24,4f,45,6f,12,34f};



    }

    void Learn1DArray()
    {
        // 2-D Array 
        int [,] agesMatrix = new int{10,15};
        agesMatrix[0,0]=4567;

        //3-D Array

        int(,,) agesMatrix3D = new int[10,15,6];

    string[,]names = new string[,]{{"ishwor", "suvash"},{"ishwor", "suvash"}};

    //23,45,67,87
    //23,15,67
    //23,45,57,87

    
    }

    void LearnJaggedArray()
    {
        byte[][] personAges = new byte[3][];
        personAges[0] = new byte[2]{34,56};
        personAges[1] = new byte[]{34,56,23,45,67};
        personAges[2] = new byte[]{34,56,23,45};
        personAges[3] = new byte[]{34,56,23,45,80};
}