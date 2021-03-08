using System;

namespace inclass_3_3_string_another_way
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string message = "tAylOr SwIFt, tHe WeEknD, aRIANa gRAnde, biLlie eiLiSh";
            string message2 = "tAylOr SwIFt";
            int indexofspace = message2.IndexOf(' ');
           

            

            

                                        
            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            Console.WriteLine($"{newMessage}");

            // square brackets by string is a collection: meaning an array of strings
            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();
                message2 = message2.ToUpper()[0] + message2.ToLower().Substring(1, indexofspace)
                           // substring starts with a in taylor and ends with the space
                           + message2.ToUpper()[indexofspace + 1] + message2.ToLower().Substring(indexofspace + 2);
                //substring starts with S and goes to end
                Console.WriteLine(message2);

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
