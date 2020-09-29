using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace RA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RA1";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("|Read Analyzer 1                                                              |");
            Console.WriteLine("|                         WELCOME                          C2015.8.7[1.0.0.0] |");
            Console.WriteLine("|  For assistance, view documentation that is included                        |");
            Console.WriteLine("|    Press any Key to continue                                                |");
            Console.WriteLine("------------------------------------------------------------------------------");
           
           
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        










        mainpage:
            Console.Clear();
            //variable defintion sector

          //  string TempCharDef = charDef;
         
            string fileName = " ";
            bool bs = false;
            string document;
           
            Random rand = new Random();
            int rnd;
          
            rnd = rand.Next(93);
           
            string translate = " ";
             
            string[] NOrepeat = new string[94];
            int count;
            //   string newDocument = "";
            //end of variable sector



            Console.WriteLine(Environment.CurrentDirectory);
            string[] files = null;
            try
            {
                files = System.IO.Directory.GetFiles(Environment.CurrentDirectory);
            }
            catch (UnauthorizedAccessException e)
            {

                Console.WriteLine(e.Message);

            }
            string tempDIR = Environment.CurrentDirectory;
            count = 0;
            foreach (char ch in tempDIR)
            {
                count++;
            }
            string test = "";
            count++;//adds one
            foreach (string d in files)
            {

                test = d.Remove(0, count);
                //     Console.WriteLine(d);
                Console.WriteLine(test);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
          

            do
            {
                Console.WriteLine("Type in a file to analyze" );
                Console.WriteLine("Type 'back' to return");

                fileName = Console.ReadLine();
                string tempStr = fileName;
                tempStr = tempStr.ToUpper();
                if (tempStr == "BACK")
                {
                    Console.Clear();
                    goto mainpage;
                }
                try
                {
                    StreamReader DUMB = new StreamReader(fileName);


                    document = DUMB.ReadToEnd();


                    bs = true;//exits loop
                    DUMB.Close();
                }
                catch (Exception ex)
                {
                    File.WriteAllText("debug.txt", ex.ToString());
                    Console.WriteLine("The file entered was invalid. For more information, see the debug file that has been generated");
                }
            } while (bs == false);


            string[] newDocumentN = File.ReadLines(fileName).ToArray();

            translate = File.ReadAllText(fileName).ToString(); //comeback later to FIX This
            Console.WriteLine("File loaded successfully. Press any key to anaylze" + fileName);
            // string[] LinePreser=new string [newDocumentN.Length]; //Attempts to preserve lines



            count = 94;//Total values
            Console.ReadKey();


            //RULES: SPOT 1 will be recorded and as matches in program, will decrease anaDOcument
            //BAsicaly anaDocument will get smaller but will 'serve as the key' for the docCount
            translate = translate.ToLower();
            string[] OrginalDoc = translate.Split(' ', '\r', '\n');
            string[] anaDocument = translate.Split(' ','\r','\n');
            int[] docCount = new int[anaDocument.Length];
            string[] OverallLayout = new string[anaDocument.Length];
            string totalAna = "Read Analyzer 1 --------------------RESULTS ON:" + DateTime.Now.ToShortDateString() + "-------------------" + Environment.NewLine;

            for (int i=0;i<anaDocument.Length;i++)
            {
                if (anaDocument[i]==null||anaDocument[i]=="")
                {
                    i++;
                    if (i>=anaDocument.Length)
                    {
                        break;
                    }
                }
                docCount[i] = 1;//starts at one
                for (int z=0;z<anaDocument.Length;z++)
                {
                    if (anaDocument[z]==null||anaDocument[z]=="")
                    {
                      
                    }
                    else
                    {
                        anaDocument[z] = anaDocument[z].Trim(',', '.', '"', '!', '?');
                        if ((anaDocument[i] == anaDocument[z]) && (anaDocument[z] != "$@$!*⌡æb◄%&")) //keeps the first one but will remove the rest
                        {
                    
                            if (i!=z)
                            {
                                anaDocument[z] = null; //the layout that says it has been used
                            
                            }
                            string spacerV2 = " ";
                            string visualUse = "";
                            string estimatedValue=anaDocument[i] + " Count: " + docCount[i] ;
                            for (int q = 0; q < docCount[i]; q++)
                            {
                                visualUse = visualUse + "*";
                            }
                          
                            do
                            {
                                spacerV2 = spacerV2 + " ";
                                estimatedValue = anaDocument[i] + " Count: " + docCount[i]+spacerV2;
                            } while (estimatedValue.Length < 50);
                           
                                docCount[i] = docCount[i] + 1;
                                OverallLayout[i] = estimatedValue + " |" + visualUse + Environment.NewLine;
                           


                        }
                    }
                   
                }
               
                    totalAna = totalAna + OverallLayout[i];
                    //  totalAna = totalAna.Trim();
               
            //    totalAna = totalAna.TrimEnd('.',',');
            
            }

            int difWords = 0;

            for (int i = 0; i < anaDocument.Length;i++ )
            {
                if (anaDocument[i]==null||anaDocument[i]=="")
                {

                }
                else
                {
                    difWords = difWords + 1;
                }
            }
            int TotWord = 0;
            int visibelChar = 0;
            for (int i = 0; i < OrginalDoc.Length;i++ )
            {
                if (OrginalDoc[i]==null||OrginalDoc[i]=="")
                {

                }
                else
                {
                    visibelChar = visibelChar + OrginalDoc[i].Length;
                    TotWord = TotWord + 1;
                }
            }
                Console.WriteLine();
                File.WriteAllText("Anaylzed" + fileName + ".txt", fileName + " contains " + TotWord.ToString() + " words in document." + Environment.NewLine + "Presently there are " + visibelChar.ToString() + " charecters in place.(NO SPACES)" + Environment.NewLine + "Of which there are " + difWords + " diffrent words in it." + Environment.NewLine + Environment.NewLine + totalAna);
                Console.WriteLine("Sucessfully wrote Analyzed file contents in directory. Summary can be found below or in text document.");
                Console.WriteLine("Anaylzed" + fileName + ".txt", fileName + " contains " + TotWord.ToString() + " words in document." + Environment.NewLine + "Presently there are " + visibelChar.ToString() + " charecters in place." + Environment.NewLine + "Of which there are " + difWords + " diffrent words in it.");
                Console.WriteLine();
                Console.WriteLine()
                    ;
                Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
                goto mainpage;
        }
    }
}



//8-7-15 1.0.0.0
//Well, did this program in a day
//not much to say other than that it is designed to give a visual chart of 
//the most used words in a document
