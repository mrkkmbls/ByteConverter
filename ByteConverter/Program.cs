using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the path to the JPEG image: ");
            string jpegFilePath = Console.ReadLine().Replace("\\", "/");

            // Set the desired output directory path
            string outputDirectory = "D:/Projects/Byte Converter/Test Images"; // Replace with your desired directory

            Console.Write("Enter the desired output filename: ");
            string outputFilename = Console.ReadLine();

            // Combine the output directory, filename, and .webp extension
            string webpFilePath = $"{outputDirectory}/{outputFilename}.webp";

            var imageConverter = new ImageConverter();
            imageConverter.ConvertToWebP(jpegFilePath, webpFilePath);

            Console.WriteLine($"Image conversion to WebP completed successfully. Output saved to {webpFilePath}");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
