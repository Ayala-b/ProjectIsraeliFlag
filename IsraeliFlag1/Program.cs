using System;

class FlagOfIsrael
{
    // Function to print the flag's horizontal stripes
    static void PrintHorizontalStripe(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(new string('*', width));
        }
    }

    // Function to print the Star of David in the center
    static void PrintStarOfDavid(int n, int israeliflagWidth)
    {
        int starOfDavidWidth = 2 * n - 1;
        int leftPadding = (israeliflagWidth - starOfDavidWidth) / 2;

        // Top vertex of the Star of David
        Console.WriteLine(new string(' ', leftPadding + n - 1) + "*");

        // Second row with two stars
        Console.WriteLine(new string(' ', leftPadding + n - 2) + "*" + new string(' ', 1) + "*");

        // Top stripe of the Star of David
        Console.WriteLine(new string(' ', leftPadding - 1) + new string('*', starOfDavidWidth) + "**");

        // Interleaving upper and lower triangles
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write(new string(' ', leftPadding));
            for (int j = 0; j < starOfDavidWidth; j++)
            {
                if (j == i - 1 || j == starOfDavidWidth - i || j == n - 2 - i || j == n + i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        // Bottom stripe of the Star of David
        Console.WriteLine(new string(' ', leftPadding - 1) + new string('*', starOfDavidWidth) + "**");

        // Bottom row with two stars
        Console.WriteLine(new string(' ', leftPadding + n - 2) + "*" + new string(' ', 1) + "*");

        // Bottom vertex of the Star of David
        Console.WriteLine(new string(' ', leftPadding + n - 1) + "*");
    }

    static void Main()
    {
        // Get user input for flag dimensions
        Console.Write("Enter the width of the flag between 20 to 160: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the flag between 20 to 160: ");
        int height = int.Parse(Console.ReadLine());

        // Calculate flag parameters
        int horizontalStripeHeight = Math.Max(height / 10, 1); 
        int starSize = Math.Min(width, height) / 4; 

        // Print the top stripe
        PrintHorizontalStripe(width, horizontalStripeHeight);

        // Space above the Star of David
        int spaceAboveStar = (height - 2 * horizontalStripeHeight - starSize) / 2;
        for (int i = 0; i < spaceAboveStar; i++)
        {
            Console.WriteLine(new string(' ', width));
        }

        // Print the Star of David in the center
        PrintStarOfDavid(starSize, width);

        // Space below the Star of David
        for (int i = 0; i < spaceAboveStar; i++)
        {
            Console.WriteLine(new string(' ', width));
        }

        // Print the bottom stripe
        PrintHorizontalStripe(width, horizontalStripeHeight);
    }
}
