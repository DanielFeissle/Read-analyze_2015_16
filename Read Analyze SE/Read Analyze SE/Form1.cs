using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Read_Analyze_SE
{
     

    public partial class frm_main : Form
    {
        string translate = " ";
        string charDef = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-=+_) (*&^%$#@![]\';/.,<>?:{}|~`";
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            if (dlg_OPEN.ShowDialog()==DialogResult.OK) //good to open filename
            {
                lbl_SEARCH.Text = "Search (NO FILE)";
                lbl_status.Text = "Status: READY";
                prg_status.Value = 0;
                string[] newDocumentN = File.ReadLines(dlg_OPEN.FileName).ToArray();
                translate = File.ReadAllText(dlg_OPEN.FileName).ToString(); //comeback later to FIX This
                this.Text = "RASE--" + dlg_OPEN.FileName;
                
                

                //RULES: SPOT 1 will be recorded and as matches in program, will decrease anaDOcument
                //BAsicaly anaDocument will get smaller but will 'serve as the key' for the docCount
                translate = translate.ToLower();
               for (int f=0;f<translate.Length;f++) //for each letter present
               {
                   int strikAgasintLetter = 0;
                   for (int d=0;d<charDef.Length;d++) //for each chardef
                   {
                      // if (!translate.Substring(f,1).Contains(charDef))
                       if (translate.Substring(f,1)!=charDef.Substring(d,1))
                       {
                           strikAgasintLetter++;
                       }
                      
                   }
                   if (strikAgasintLetter>=93)
                   {
                       translate = translate.Remove(f,1);
                   }
                 
               }
                //STAGE ONE CHECK FOR VALID CHARECTERS
               lbl_status.Text = "Status: CLEANING";
               prg_status.Value = 10;
               rtx_ImportedFile.Text = "--BELOW IS HOW READ ANALZYE HAS READ THE FILE--" + Environment.NewLine + translate;
               tabControl1.SelectedTab = tab_ImportedDoc;
                string[] OrginalDoc = translate.Split(' ', '\r', '\n','\t');
                string[] anaDocument = translate.Split(' ', '\r', '\n','\t');
                string[] sentAna = translate.Split(' ', '\r', '\n','\t');
                int[] docCount = new int[anaDocument.Length];
                int[] docSentCount = new int[sentAna.Length];
                string[] OverallLayout = new string[anaDocument.Length];
                string[] SentOverallLayout = new string[anaDocument.Length];
                string totalAna = "Read Analyzer SE RA1 --------------------RESULTS ON:" + DateTime.Now.ToShortDateString() + "-------------------" + Environment.NewLine+" --THIS COUNTS THE TOTAL WORD VARIANCE--"+Environment.NewLine;
                string totalSent = "Read Analyzer SE SAV1--------------------RESULTS ON:" + DateTime.Now.ToShortDateString() + "-------------------" + Environment.NewLine+"    --THIS COUNTS THE AMOUNT OF DIFFRENT WORDS USED TO START A SENTENCE--"+Environment.NewLine;
                //STAGE TWO LET USER KNOW NEXT STEP IN THIS CASE PRE WORD VARIENCE COUNT
                lbl_status.Text = "Status: PRE-W_COUNT";
                prg_status.Value = 20;
               // tabControl1.SelectedTab = tab_WORDV;
                for (int i = 0; i < anaDocument.Length; i++)
                {
                    if (anaDocument[i] == null || anaDocument[i] == "")
                    {
                        i++;
                        if (i >= anaDocument.Length)
                        {
                            break;
                        }
                    }
                    docCount[i] = 1;//starts at one
                    for (int z = 0; z < anaDocument.Length; z++)
                    {
                        if (anaDocument[z] == null || anaDocument[z] == "")
                        {

                        }
                        else
                        {
                            anaDocument[z] = anaDocument[z].Trim(',', '.', '"', '!', '?');
                            if ((anaDocument[i] == anaDocument[z]) && (anaDocument[z] != "$@$!*⌡æb◄%&")) //keeps the first one but will remove the rest
                            {

                                if (i != z)
                                {
                                    anaDocument[z] = null; //the layout that says it has been used

                                }
                                string spacerV2 = " ";
                                string visualUse = "";
                                string estimatedValue = anaDocument[i] + " Count: " + docCount[i];
                                for (int q = 0; q < docCount[i]; q++)
                                {
                                    visualUse = visualUse + "*";
                                }

                                do
                                {
                                    spacerV2 = spacerV2 + " ";
                                    estimatedValue = anaDocument[i] + " Count: " + docCount[i] + spacerV2;
                                } while (estimatedValue.Length < 50);

                                docCount[i] = docCount[i] + 1;
                                OverallLayout[i] = estimatedValue + " |" + visualUse + Environment.NewLine;

                                

                            }
                        }

                    }

                    //STAGE THREE COUNT SENTENCE VARIENCE
                    lbl_status.Text = "Status: PRE-S_COUNT";
                    prg_status.Value = 50;

                    //REPEAT BUT FOR START SENTENCE ANALZYE
                    docSentCount[i] = 1;//starts at one
                //    tabControl1.SelectedTab = tab_Sentence;
                    for (int z = 0; z < sentAna.Length; z++)
                    {
                        if (z>0)
                        {
                            if (sentAna[z - 1] == null || sentAna[z - 1] == "")
                            {
                                sentAna[z - 1] = "";
                            }
                           
                        }
                      
                       // else
                       // {
                          //  sentAna[z] = sentAna[z].Trim('.', '!', '?');
                            if (z!=0) //since it is the first one, there is not a sentence prior to it
                            {

                                //     if ((sentAna[i] == sentAna[z]) && (sentAna[z] != "$@$!*⌡æb◄%&") && (sentAna[i - 1].Contains('.') || sentAna[i - 1].Contains('?') || sentAna[i - 1].Contains('!')))  //keeps the first one but will remove the rest
                               
                                //legacy backup
                               
 
                                
                                    if ((sentAna[i] == sentAna[z]) && (sentAna[z] != "$@$!*⌡æb◄%&") && (sentAna[z - 1].Contains('.') || sentAna[z - 1].Contains('?') || sentAna[z - 1].Contains('!')))  //keeps the first one but will remove the rest
                                    {

                                        if (i != z)
                                        {
                                            sentAna[z] = null; //the layout that says it has been used

                                        }
                                        string spacerV2 = " ";
                                        string visualUse = "";
                                        string estimatedValue = sentAna[i] + " Count: " + docSentCount[i];
                                        for (int q = 0; q < docSentCount[i]; q++)
                                        {
                                            visualUse = visualUse + "*";
                                        }

                                        do
                                        {
                                            spacerV2 = spacerV2 + " ";
                                            estimatedValue = sentAna[i] + " Count: " + docSentCount[i] + spacerV2;
                                        } while (estimatedValue.Length < 50);

                                        docSentCount[i] = docSentCount[i] + 1;
                                        SentOverallLayout[i] = estimatedValue + " |" + visualUse + Environment.NewLine;



                                    }
                                 

                        //    }
                           
                    
                        }

                    }
                
                    //STAGE FOUR FINISHED COUNTING
                    lbl_status.Text = "Status: COUNT DONE";
                    prg_status.Value = 100;
                    tmr_FADE.Start();
                    if (sentAna[i]=="")
                    {
                       
                    }
                    else
                    {
                        totalSent = totalSent + SentOverallLayout[i];
                    }
                    totalAna = totalAna + OverallLayout[i];
                   
                    //  totalAna = totalAna.Trim();

                    //    totalAna = totalAna.TrimEnd('.',',');

                }

                int difWords = 0;
            //    tabControl1.SelectedTab = tab_Overview;
                for (int i = 0; i < anaDocument.Length; i++)
                {
                    if (anaDocument[i] == null || anaDocument[i] == "")
                    {

                    }
                    else
                    {
                        difWords = difWords + 1;
                    }
                }
                int TotWord = 0;
                int visibelChar = 0;
                for (int i = 0; i < OrginalDoc.Length; i++)
                {
                    if (OrginalDoc[i] == null || OrginalDoc[i] == "")
                    {

                    }
                    else
                    {
                        visibelChar = visibelChar + OrginalDoc[i].Length;
                        TotWord = TotWord + 1;
                    }
                }
                Console.WriteLine();
                int wordVariance = (difWords*100 / TotWord*100);
                rtx_OverView.Text = dlg_OPEN.FileName + " contains " + TotWord.ToString() + " words in document." + Environment.NewLine + "Presently there are " + visibelChar.ToString() + " charecters in place.(NO SPACES)" + Environment.NewLine + "Of which there are " + difWords + " diffrent words in it." + Environment.NewLine + Environment.NewLine+"Diffrent word ratio: "+wordVariance.ToString().Substring(0,2) +"%, the document has been rated ";
                string docRating = "";
                if (wordVariance<2000)
               {
                   docRating = "copy pasta, apparently";
               }
               else if (wordVariance<4000)
               {
                   docRating = "standard amount of variance detected";
               }
               else if (wordVariance<6000)
               {
                   docRating = "amazing use of word variety";
               }
               else if (wordVariance<8000)
               {
                   docRating = "wozerdedepdut is a word which means wow";
               }
               else
               {
                   docRating = "a creative combiniation of words";
               }


                rtx_OverView.Text = rtx_OverView.Text + docRating+"!!";
                rtx_SentenceAna.Text = totalSent;
                rtxt_WordVariety.Text = totalAna;
              //  File.WriteAllText("Anaylzed" + dlg_OPEN.FileName + ".txt", dlg_OPEN.FileName + " contains " + TotWord.ToString() + " words in document." + Environment.NewLine + "Presently there are " + visibelChar.ToString() + " charecters in place.(NO SPACES)" + Environment.NewLine + "Of which there are " + difWords + " diffrent words in it." + Environment.NewLine + Environment.NewLine + totalAna);
                Console.WriteLine("Sucessfully wrote Analyzed file contents in directory. Summary can be found below or in text document.");
                Console.WriteLine("Anaylzed" + dlg_OPEN.FileName + ".txt", dlg_OPEN.FileName + " contains " + TotWord.ToString() + " words in document." + Environment.NewLine + "Presently there are " + visibelChar.ToString() + " charecters in place." + Environment.NewLine + "Of which there are " + difWords + " diffrent words in it.");
                Console.WriteLine();
                Console.WriteLine()
                    ;
                Console.WriteLine("Press any key to return to menu");
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            tls_SEARCHFIND.SelectedIndex = 0;
            dlg_OPEN.InitialDirectory = Environment.CurrentDirectory;
            dlg_SAVE.InitialDirectory = Environment.CurrentDirectory;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
          if (dlg_SAVE.ShowDialog()==DialogResult.OK)
          {
              File.WriteAllText(dlg_SAVE.FileName, rtx_OverView.Text + Environment.NewLine + Environment.NewLine + rtxt_WordVariety.Text + Environment.NewLine + Environment.NewLine + rtx_SentenceAna.Text);
          }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {

            RASEAbout myMessageForm = new RASEAbout();
            myMessageForm.ShowDialog();
        }

        private void txt_SEARCH_Click(object sender, EventArgs e)
        {
         
        }

        private void tmr_FADE_Tick(object sender, EventArgs e)
        {
            lbl_status.Text = "Status: READY";
            prg_status.Value = 0;
            tmr_FADE.Stop();
        }
        string bla = null;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tls_SEARCHFIND.SelectedIndex==0) //FIND the words preceding the docuemnt
            {
 string totalAna = "Read Analyzer SE RA1 --------------------RESULTS ON:" + DateTime.Now.ToShortDateString() + "-------------------" + Environment.NewLine + " --THIS COUNTS THE TOTAL WORD VARIANCE--" + Environment.NewLine;
            string totalSent = "Read Analyzer SE SEAV1--------------------RESULTS ON:" + DateTime.Now.ToShortDateString() + "-------------------" + Environment.NewLine + "    --THIS COUNTS THE AMOUNT OF DIFFRENT WORDS USED TO START WITH '"+txt_SEARCH.Text+"'--" + Environment.NewLine;
           
            tabControl1.SelectedTab = tab_Search;
            //BASICALLY A COPY PASTE FROM ABOVE BUT TAKES IN THE SEARCH PARAMETER INSTEAD
            lbl_status.Text = "Status: PRE READ";
            prg_status.Value = 20;
           
            string[] anaDocument = translate.Split(' ', '\r', '\n', '\t');
            string[] SentOverallLayout = new string[anaDocument.Length];
            string[] sentAna = translate.Split(' ', '\r', '\n', '\t');
            int[] docSentCount = new int[sentAna.Length];
            string[] OverallLayout = new string[anaDocument.Length];
            lbl_status.Text = "Status: SEARCHING";
            prg_status.Value = 40;
             
            for (int i = 0; i < anaDocument.Length; i++)
            {
                //REPEAT BUT FOR SEARCH ANALZYE
                docSentCount[i] = 1;//starts at one
                for (int z = 0; z < sentAna.Length; z++)
                {
                    if (z > 0)
                    {
                        if (sentAna[z - 1] == null || sentAna[z - 1] == "")
                        {
                            sentAna[z - 1] = "";
                        }

                    }

                    // else
                    // {
                    //  sentAna[z] = sentAna[z].Trim('.', '!', '?');
                    if (z != 0) //since it is the first one, there is not a sentence prior to it
                    {

                        //     if ((sentAna[i] == sentAna[z]) && (sentAna[z] != "$@$!*⌡æb◄%&") && (sentAna[i - 1].Contains('.') || sentAna[i - 1].Contains('?') || sentAna[i - 1].Contains('!')))  //keeps the first one but will remove the rest

                        //legacy backup



                        if ((sentAna[i] == sentAna[z]) && (sentAna[z] != "$@$!*⌡æb◄%&") && (sentAna[z - 1]==(txt_SEARCH.Text))) //|| sentAna[z - 1].Contains('?') || sentAna[z - 1].Contains('!')))  //keeps the first one but will remove the rest
                        {

                            if (i != z)
                            {
                                sentAna[z] = null; //the layout that says it has been used

                            }
                            string spacerV2 = " ";
                            string visualUse = "";
                            string estimatedValue = sentAna[i] + " Count: " + docSentCount[i];
                            for (int q = 0; q < docSentCount[i]; q++)
                            {
                                visualUse = visualUse + "*";
                            }

                            do
                            {
                                spacerV2 = spacerV2 + " ";
                                estimatedValue = sentAna[i] + " Count: " + docSentCount[i] + spacerV2;
                            } while (estimatedValue.Length < 50);

                            docSentCount[i] = docSentCount[i] + 1;
                            SentOverallLayout[i] = estimatedValue + " |" + visualUse + Environment.NewLine;



                        }


                        //    }


                    }

                }
                lbl_status.Text = "Status: COMPLETE";
                prg_status.Value = 60;
                if (sentAna[i] == "")
                {

                }
                else
                {
                    totalSent = totalSent + SentOverallLayout[i];
                }
                lbl_status.Text = "Status: DISPLAYING";
                prg_status.Value = 77
                    ;
                totalAna = totalAna + OverallLayout[i];

                rtx_SEARCH.Text = totalSent;
                
            }
            lbl_SEARCH.Text = "Search (FOUND)";
            lbl_status.Text = "Status: SEARCH DONE";
            prg_status.Value = 100;
            tmr_FADE.Start();
            }
            else if (tls_SEARCHFIND.SelectedIndex==1) //Search the document for the word
            {
            //   tabControl1.SelectedTab = tab_ImportedDoc;
                if (searchLocation>rtx_ImportedFile.Text.Length)
                {
                    searchLocation = 0; //reset the counter to go through the document
                }
             
               
                int tempSearchLocation = 0;
                int totSEARCHval = txt_SEARCH.TextLength;
                int charSearch = txt_SEARCH.Text.Length;
               
                if (tabControl1.SelectedTab == tab_ImportedDoc)
                {
                    //precahche per search
                    if (nothingChanged==1)
                    {
                        lbl_SEARCH.Text = "Search (PRECACHE)";
                        nothingChanged = 0;
                        for (int z = tempSearchLocation; z < rtx_ImportedFile.Text.Length; z++)
                        {
                            if (tempSearchLocation + charSearch > rtx_ImportedFile.Text.Length) //reset the location
                            {


                                break;
                            }
                            if (rtx_ImportedFile.Text.Substring(tempSearchLocation, charSearch).ToLower() == txt_SEARCH.Text.ToLower()) //bring file to lower value to find anything
                            {
                                totSearchCount++;
                                rtx_ImportedFile.Focus();
                                rtx_ImportedFile.Select(tempSearchLocation, charSearch);
                                bla = bla + tempSearchLocation + "#";

                            }
                            tempSearchLocation++;

                        }
                       
                      
                    }

                    //new standard search
                    if (bla!=null)
                    {
                        string[] splitnum = bla.Split('#');
                        if (splitnum[curSearchCount] != "")
                        {
                            searchLocation = Convert.ToInt32(splitnum[curSearchCount]);
                        }
                        else //reached the end of the read file
                        {
                              curSearchCount = 0;
                              searchLocation = Convert.ToInt32(splitnum[0]);
                        }

                        curSearchCount++;
                        rtx_ImportedFile.Focus();
                        rtx_ImportedFile.Select(searchLocation, charSearch);
                        searchLocation++;
                        lbl_SEARCH.Text = "Search (" + curSearchCount + "/" + totSearchCount + ")";
                    }
                    else
                    {
                        curSearchCount = 0;
                        searchLocation = 0;
                        totSearchCount = 0;
                        lbl_SEARCH.Text = "Search (NO MATCH)";
                    }
                   
                    /*
                    //standard search
                    for (int z=searchLocation;z<rtx_ImportedFile.Text.Length;z++)
                    {
                        if (searchLocation+charSearch  >= rtx_ImportedFile.Text.Length) //reset the location
                        {
                            curSearchCount = 0;
                            searchLocation = 0;
                            break;
                        }
                        if (rtx_ImportedFile.Text.Substring(searchLocation,charSearch).ToLower()==txt_SEARCH.Text.ToLower()) //bring file to lower value to find anything
                        {
                            curSearchCount++;
                            rtx_ImportedFile.Focus();
                            rtx_ImportedFile.Select(searchLocation, charSearch);
                            searchLocation++;
                            lbl_SEARCH.Text = "Search ("+curSearchCount+"/"+totSearchCount+")";
                            break;
                        }
                        else
                        {
                            if (curSearchCount>0)
                            {
                                lbl_SEARCH.Text = "Search (END)";
                            }
                            else
                            {
                                lbl_SEARCH.Text = "Search (NOT FOUND)";
                            }
                          
                        }
                      
                        searchLocation++;
                    }
                     
                      */
                   
                }
                else if (tabControl1.SelectedTab==tab_Overview) //###################################################################
                {
                    //precahche per search
                    if (nothingChanged == 1)
                    {
                        lbl_SEARCH.Text = "Search (PRECACHE)";
                        nothingChanged = 0;
                        for (int z = tempSearchLocation; z < rtx_OverView.Text.Length; z++)
                        {
                            if (tempSearchLocation + charSearch > rtx_OverView.Text.Length) //reset the location
                            {


                                break;
                            }
                            if (rtx_OverView.Text.Substring(tempSearchLocation, charSearch).ToLower() == txt_SEARCH.Text.ToLower()) //bring file to lower value to find anything
                            {
                                totSearchCount++;
                                rtx_OverView.Focus();
                                rtx_OverView.Select(tempSearchLocation, charSearch);
                                bla = bla + tempSearchLocation + "#";

                            }
                            tempSearchLocation++;

                        }


                    }

                    //new standard search
                    if (bla != null)
                    {
                        string[] splitnum = bla.Split('#');
                        if (splitnum[curSearchCount] != "")
                        {
                            searchLocation = Convert.ToInt32(splitnum[curSearchCount]);
                        }
                        else //reached the end of the read file
                        {
                            curSearchCount = 0;
                            searchLocation = Convert.ToInt32(splitnum[0]);
                        }

                        curSearchCount++;
                        rtx_OverView.Focus();
                        rtx_OverView.Select(searchLocation, charSearch);
                        searchLocation++;
                        lbl_SEARCH.Text = "Search (" + curSearchCount + "/" + totSearchCount + ")";
                    }
                    else
                    {
                        curSearchCount = 0;
                        searchLocation = 0;
                        totSearchCount = 0;
                        lbl_SEARCH.Text = "Search (NO MATCH)";
                    }
                }
                else if (tabControl1.SelectedTab == tab_WORDV) //######################################################################
                {
                    //precahche per search
                    if (nothingChanged == 1)
                    {
                        lbl_SEARCH.Text = "Search (PRECACHE)";
                        nothingChanged = 0;
                        for (int z = tempSearchLocation; z < rtxt_WordVariety.Text.Length; z++)
                        {
                            if (tempSearchLocation + charSearch > rtxt_WordVariety.Text.Length) //reset the location
                            {


                                break;
                            }
                            if (rtxt_WordVariety.Text.Substring(tempSearchLocation, charSearch).ToLower() == txt_SEARCH.Text.ToLower()) //bring file to lower value to find anything
                            {
                                totSearchCount++;
                                rtxt_WordVariety.Focus();
                                rtxt_WordVariety.Select(tempSearchLocation, charSearch);
                                bla = bla + tempSearchLocation + "#";

                            }
                            tempSearchLocation++;

                        }


                    }

                    //new standard search
                    if (bla != null)
                    {
                        string[] splitnum = bla.Split('#');
                        if (splitnum[curSearchCount] != "")
                        {
                            searchLocation = Convert.ToInt32(splitnum[curSearchCount]);
                        }
                        else //reached the end of the read file
                        {
                            curSearchCount = 0;
                            searchLocation = Convert.ToInt32(splitnum[0]);
                        }

                        curSearchCount++;
                        rtxt_WordVariety.Focus();
                        rtxt_WordVariety.Select(searchLocation, charSearch);
                        searchLocation++;
                        lbl_SEARCH.Text = "Search (" + curSearchCount + "/" + totSearchCount + ")";
                    }
                    else
                    {
                        curSearchCount = 0;
                        searchLocation = 0;
                        totSearchCount = 0;
                        lbl_SEARCH.Text = "Search (NO MATCH)";
                    }
                }
                else if (tabControl1.SelectedTab == tab_Sentence) //##################################################################
                {
                    //precahche per search
                    if (nothingChanged == 1)
                    {
                        lbl_SEARCH.Text = "Search (PRECACHE)";
                        nothingChanged = 0;
                        for (int z = tempSearchLocation; z < rtx_SentenceAna.Text.Length; z++)
                        {
                            if (tempSearchLocation + charSearch > rtx_SentenceAna.Text.Length) //reset the location
                            {


                                break;
                            }
                            if (rtx_SentenceAna.Text.Substring(tempSearchLocation, charSearch).ToLower() == txt_SEARCH.Text.ToLower()) //bring file to lower value to find anything
                            {
                                totSearchCount++;
                                rtx_SentenceAna.Focus();
                                rtx_SentenceAna.Select(tempSearchLocation, charSearch);
                                bla = bla + tempSearchLocation + "#";

                            }
                            tempSearchLocation++;

                        }


                    }

                    //new standard search
                    if (bla != null)
                    {
                        string[] splitnum = bla.Split('#');
                        if (splitnum[curSearchCount] != "")
                        {
                            searchLocation = Convert.ToInt32(splitnum[curSearchCount]);
                        }
                        else //reached the end of the read file
                        {
                            curSearchCount = 0;
                            searchLocation = Convert.ToInt32(splitnum[0]);
                        }

                        curSearchCount++;
                        rtx_SentenceAna.Focus();
                        rtx_SentenceAna.Select(searchLocation, charSearch);
                        searchLocation++;
                        lbl_SEARCH.Text = "Search (" + curSearchCount + "/" + totSearchCount + ")";
                    }
                    else
                    {
                        curSearchCount = 0;
                        searchLocation = 0;
                        totSearchCount = 0;
                        lbl_SEARCH.Text = "Search (NO MATCH)";
                    }
                }
                else if (tabControl1.SelectedTab == tab_Search)//######################################################################
                {
                    //precahche per search
                    if (nothingChanged == 1)
                    {
                        lbl_SEARCH.Text = "Search (PRECACHE)";
                        nothingChanged = 0;
                        for (int z = tempSearchLocation; z < rtx_SEARCH.Text.Length; z++)
                        {
                            if (tempSearchLocation + charSearch > rtx_SEARCH.Text.Length) //reset the location
                            {


                                break;
                            }
                            if (rtx_SEARCH.Text.Substring(tempSearchLocation, charSearch).ToLower() == txt_SEARCH.Text.ToLower()) //bring file to lower value to find anything
                            {
                                totSearchCount++;
                                rtx_SEARCH.Focus();
                                rtx_SEARCH.Select(tempSearchLocation, charSearch);
                                bla = bla + tempSearchLocation + "#";

                            }
                            tempSearchLocation++;

                        }


                    }

                    //new standard search
                    if (bla != null)
                    {
                        string[] splitnum = bla.Split('#');
                        if (splitnum[curSearchCount] != "")
                        {
                            searchLocation = Convert.ToInt32(splitnum[curSearchCount]);
                        }
                        else //reached the end of the read file
                        {
                            curSearchCount = 0;
                            searchLocation = Convert.ToInt32(splitnum[0]);
                        }

                        curSearchCount++;
                        rtx_SEARCH.Focus();
                        rtx_SEARCH.Select(searchLocation, charSearch);
                        searchLocation++;
                        lbl_SEARCH.Text = "Search (" + curSearchCount + "/" + totSearchCount + ")";
                    }
                    else
                    {
                        curSearchCount = 0;
                        searchLocation = 0;
                        totSearchCount = 0;
                        lbl_SEARCH.Text = "Search (NO MATCH)";
                    }
                }
             
            }



           
        }
        int nothingChanged = 1; //something changed orginally :)
        int searchLocation = 0;
        int curSearchCount = 0;
        int totSearchCount = 0;
        private void tmr_UX_Tick(object sender, EventArgs e)
        {

        }

        private void tls_SEARCHFIND_Click(object sender, EventArgs e)
        {
         
        }

        private void tls_SEARCHFIND_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tls_SEARCHFIND_DropDownClosed(object sender, EventArgs e)
        {

            btn_FIND.Text = tls_SEARCHFIND.SelectedItem.ToString();
        }

        private void txt_SEARCH_TextChanged(object sender, EventArgs e)
        {
            
            totSearchCount = 0;
            nothingChanged = 1;
            curSearchCount = 0;
            searchLocation = 0;
            lbl_SEARCH.Text = "Search (CLEAR)";
            bla = null;
            
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
            totSearchCount = 0;
            nothingChanged = 1;
            curSearchCount = 0;
            searchLocation = 0;
            lbl_SEARCH.Text = "Search (CLEAR)";
            bla =null;
        }

        private void tabControl1_TabStopChanged(object sender, EventArgs e)
        {
         
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            totSearchCount = 0;
            nothingChanged = 1;
            curSearchCount = 0;
            searchLocation = 0;
            lbl_SEARCH.Text = "Search (CLEAR)";
            bla = null;
        }
    }
}

//5-8-16
//RASE is descently complete
//First this program is built off of RA1 except now it has a GUI and analzyes starting sentence words
//Now, school is practically complete, this program concludes the junior year of college
//I only have two finals: system analsis on monday 3-5pm and finance on tuesday 10-12 am
