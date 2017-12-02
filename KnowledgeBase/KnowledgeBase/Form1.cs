using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase
{
    public partial class Form1 : Form
    {
        private KnowledgeBaseEntities BugReportDatabase;
        public Form1()
        {
            InitializeComponent();
            BugReportDatabase = new KnowledgeBaseEntities();

            
            
            BugReportDatabase.Administrators.Add(new Administrator
            {
                username = "Eric",
                password = "password1"
            });//Eric, password1
            /*
            BugReportDatabase.Developers.Add(new Developer
            {
                Id = 2,
                username = "Justin",
                password = "password2"
            });//Justin, password2
            
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "AspectJ"
            });//AspectJ
            
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "Eclipse"
            });//Eclipse
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "exception"
            });//exception
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "header"
            });//header
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "headers"
            });//headers
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "threads"
            });//threads
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "thread"
            });//thread
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "Thread"
            });//Thread
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "Java"
            });//Java
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "CompilationAndWeavingContext"
            });//CompilationAndWeavingContext
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "contextMap"
            });//contextMap
            
            
            BugReportDatabase.SolvedReports.Add(new SolvedReport
            {
                Id = 14,
                error_code = 394535,
                software_version = "1.1.2",
                description = "Build Identifier: 1.6.11 The static contextMap in CompilationAndWeavingContext keeps strong references to Thread instances",
                solution = "Bug 394535 Java throws OutOfMemory in call to Class.getGenericSuperclass() on woven class"
            });//14,394535,contextMap,CompilationAndWeavingContext,Thread
            */
        
        }

        private void userSearchButton_Click(object sender, EventArgs e)
        {
            SolvedReport solvedDummy = new SolvedReport();
            userNarrator.Text = "";
            if (!string.IsNullOrEmpty(userEnterErrorCodeBox.Text))//if the user entered something in the Error Code field
            {
                if(!string.IsNullOrEmpty(userEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(userEnterDescriptionBox.Text))
                    {
                        int codeDummy;
                        if (int.TryParse(userEnterErrorCodeBox.Text, out codeDummy))
                        {
                            solvedDummy.error_code = codeDummy;
                            solvedDummy.software_version = userEnterVersionBox.Text;
                            solvedDummy.description = userEnterDescriptionBox.Text;
                        }
                        else
                        {
                            userNarrator.Text += Environment.NewLine + "Please Enter an Integer in Error Code.";
                        }
                    }
                    else
                    {
                        userNarrator.Text += Environment.NewLine + "Please Enter a Description";
                    }
                }
                else
                {
                    userNarrator.Text += Environment.NewLine + "Please enter a Software Version.";
                }
            }
            else
            {
                userNarrator.Text += Environment.NewLine + "Please enter an Error Code";
            }
            
            userSubmitButton.Enabled = true;

            var userDisplay = BugReportDatabase.SolvedReports
                .Where(s =>s.error_code == solvedDummy.error_code ||
                s.software_version.Equals(solvedDummy.software_version, StringComparison.Ordinal)||
                (matchKeywords(solvedDummy.description, s.description) >= 5)
                );//find any matching Error Code, version, or description with more than 5 matching keywords

            BindingSource userBi = new BindingSource();
            userBi.DataSource = userDisplay;
            userSolvedGridView.DataSource = userBi;
            userSolvedGridView.Refresh();
        }

        private void employeeLogin_Click(object sender, EventArgs e)
        {
            string uname, pword;
            employeeNarrator.Text = "";
            if (!string.IsNullOrEmpty(enterUsernameBox.Text))
            {
                if (!string.IsNullOrEmpty(enterPasswordBox.Text))
                {
                    uname = enterUsernameBox.Text;
                    pword = enterPasswordBox.Text;
                    
                    var findAdmin = BugReportDatabase.Administrators
                        .Where(a =>(a.username == uname) && (a.password == pword))
                        .Select(a => new { a.username, a.password });
                    
                        //find any admins in the database with that uname and pword

                        //find any devs in the database with that uname and pword

                    if (findAdmin.Any())//if it found any match
                    {
                        adminSearchButton.Enabled = true;
                    }
                    
                    
                }
                else
                {
                    employeeNarrator.Text += Environment.NewLine + "Enter a Password, genius.";
                }
            }
            else
            {
                employeeNarrator.Text += Environment.NewLine + "Enter a Username, smart guy.";
            }
        }
        private void userSubmitButton_Click(object sender, EventArgs e)
        {
            int codeDummy;
            if(!string.IsNullOrEmpty(userEnterErrorCodeBox.Text))
            {
                if(!string.IsNullOrEmpty(userEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(userEnterDescriptionBox.Text))
                    {
                        if (int.TryParse(userEnterErrorCodeBox.Text, out codeDummy))
                        {
                            UnverifiedReport reportDummy = new UnverifiedReport
                            {
                                error_code = codeDummy,
                                software_version = userEnterVersionBox.Text,
                                description = userEnterDescriptionBox.Text
                            };
                            BugReportDatabase.UnverifiedReports.Add(reportDummy);
                            BugReportDatabase.SaveChanges();
                        }
                        else
                        {
                            userNarrator.Text += Environment.NewLine + "Please Enter a valid integer for Error Code";
                        }
                    }
                    else
                    {
                        userNarrator.Text += Environment.NewLine + "Please Enter a Description";
                    }
                }
                else
                {
                    userNarrator.Text += Environment.NewLine + "Please Enter a Software Version";
                }
            }
            else
            {
                userNarrator.Text += Environment.NewLine + "Please Enter an Error Code";
            }
        }
        private int matchKeywords(string input, string against)//count how many keywords match between two strings
        {
            int count = 0;
            string[] inputWords = input.Split(' ');
            string[] againstWords = against.Split(' ');
            var keywordList = from kw in BugReportDatabase.Keywords
                              select kw;
            foreach(string iword in inputWords)
            {
                foreach (string aword in againstWords)
                {
                    if(iword.Equals(aword,StringComparison.Ordinal))
                    {
                        foreach(Keyword kw in keywordList)
                        {
                            if(iword.Equals(aword,StringComparison.Ordinal))
                            {
                                count++;
                            }
                        }//count how many matched words are keywords

                    }//find the words that match between the two strings
                }
            }
            return count;
        }

        
    }
}
