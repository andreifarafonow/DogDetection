// This file was auto-generated by ML.NET Model Builder. 

using System;
using DogDetectionML.Model;

namespace DogDetectionML.ConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                ImageSource = args[0],
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            if(predictionResult.Prediction == "Dog")
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
