using System;

namespace InClass_3_1_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "tAylOr SwIFt, tHe WeEknD, aRIANa gRAnde, biLlie eiLiSh";

            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            Console.WriteLine($"{newMessage}");

            // square brackets by string is a collection: meaning an array of strings
            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                string[] names = artist.Split(' ');
                string firstname = names[0];
                string lastName = names[1];

                string newArtist = firstname.ToUpper()[0] + firstname.ToLower().Substring(1) + " " +
                                   lastName.ToUpper()[0] + lastName.ToLower().Substring(1);
                Console.WriteLine(newArtist);

            }

            
        }
    }
}
