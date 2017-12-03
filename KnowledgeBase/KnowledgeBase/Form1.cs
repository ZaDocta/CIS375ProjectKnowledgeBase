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
            
            
            userNarrator.Text = "";
            int codeDummy;
            if (!string.IsNullOrEmpty(userEnterErrorCodeBox.Text))//if the user entered something in the Error Code field
            {
                if(!string.IsNullOrEmpty(userEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(userEnterDescriptionBox.Text))
                    {
                        if (int.TryParse(userEnterErrorCodeBox.Text, out codeDummy))
                        {
                            SolvedReport solvedDummy = new SolvedReport();
                            solvedDummy.error_code = codeDummy;
                            solvedDummy.software_version = userEnterVersionBox.Text;
                            solvedDummy.description = userEnterDescriptionBox.Text;
                            userSubmitButton.Enabled = true;
                            var userDisplay = BugReportDatabase.SolvedReports
                                .Where(s =>s.error_code == solvedDummy.error_code ||
                                s.software_version.Equals(solvedDummy.software_version, StringComparison.Ordinal)||
                                matchKeywords(solvedDummy.description, s.description) >= 5);//find any matching Error Code, version, or description with more than 5 matching keywords
                            BindingSource userBi = new BindingSource();
                            userBi.DataSource = userDisplay;
                            userSolvedGridView.DataSource = userBi;
                            userSolvedGridView.Refresh();
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
            
            
        }
        private void adminSearchButton_Click(object sender, EventArgs e)
        {
            
            
            adminNarrator.Text = "";
            int codeDummy;
            if(!string.IsNullOrEmpty(adminEnterErrorCodeBox.Text))
            {
                if(!string.IsNullOrEmpty(adminEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(adminEnterDescriptionBox.Text))
                    {
                        if (int.TryParse(userEnterErrorCodeBox.Text, out codeDummy))
                        {
                            UnverifiedReport unverDummy = new UnverifiedReport();
                            unverDummy.error_code = codeDummy;
                            unverDummy.software_version = adminEnterVersionBox.Text;
                            unverDummy.description = adminEnterDescriptionBox.Text;
                            adminSubmitButton.Enabled = true;
                            var adminDisplay = BugReportDatabase.UnverifiedReports
                                .Where(u => u.error_code == unverDummy.error_code ||
                                u.software_version.Equals(unverDummy.software_version, StringComparison.Ordinal) ||
                                matchKeywords(u.description, unverDummy.description) >= 5);
                            BindingSource adminBi = new BindingSource();
                            adminBi.DataSource = adminDisplay;
                            adminUnverifiedGridView.DataSource = adminBi;
                            adminUnverifiedGridView.Refresh();
                        }
                        else
                        {
                            adminNarrator.Text += Environment.NewLine + "Please enter a valid integer for Error Code";
                        }
                    }
                    else
                    {
                        adminNarrator.Text += Environment.NewLine + "Please enter a description.";
                    }
                }
                else
                {
                    adminNarrator.Text += Environment.NewLine + "Please enter a Software Version";
                }
            }
            else
            {
                adminNarrator.Text += Environment.NewLine + "Please enter an Error Code";
            }
        }

        private void devSearchButton_Click(object sender, EventArgs e)
        {
            int codeDummy;
            devNarrator.Text = "";
            if(!string.IsNullOrEmpty(devEnterErrorCodeBox.Text))
            {
                if(!string.IsNullOrEmpty(devEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(devEnterDescriptionBox.Text))
                    {
                        if(int.TryParse(devEnterErrorCodeBox.Text,out codeDummy))
                        {
                            VerifiedReport verifDummy = new VerifiedReport();
                            verifDummy.error_code = codeDummy;
                            verifDummy.software_version = devEnterVersionBox.Text;
                            verifDummy.description = devEnterDescriptionBox.Text;
                            devSubmitButton.Enabled = true;
                            var devDisplay = BugReportDatabase.VerifiedReports
                                .Where(v => v.error_code == verifDummy.error_code ||
                                v.software_version.Equals(verifDummy.software_version, StringComparison.Ordinal) ||
                                matchKeywords(v.description, verifDummy.description) >= 5);
                            BindingSource devBi = new BindingSource();
                            devBi.DataSource = devDisplay;
                            devVerifiedGridView.DataSource = devBi;
                            devVerifiedGridView.Refresh();
                        }
                        else
                        {
                            devNarrator.Text += Environment.NewLine + "Please enter a valid integer for Error Code.";
                        }
                    }
                    else
                    {
                        devNarrator.Text += Environment.NewLine + "Please enter a description.";
                    }
                }
                else
                {
                    devNarrator.Text += Environment.NewLine + "Please enter a software version.";
                }
            }
            else
            {
                devNarrator.Text += Environment.NewLine + "Please enter an error code";
            }
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
                    employeeNarrator.Text += Environment.NewLine + "Enter a Password.";
                }
            }
            else
            {
                employeeNarrator.Text += Environment.NewLine + "Enter a Username.";
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
                            userNarrator.Text = "Your Report has been submitted. Thank you for your feedback";
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

        private void adminSubmitButton_Click(object sender, EventArgs e)
        {
            int codeDummy;
            if(!string.IsNullOrEmpty(adminEnterErrorCodeBox.Text))
            {
                if(!string.IsNullOrEmpty(adminEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(adminEnterDescriptionBox.Text))
                    {
                        if(int.TryParse(adminEnterErrorCodeBox.Text,out codeDummy))
                        {
                            VerifiedReport reportDummy = new VerifiedReport
                            {
                                error_code = codeDummy,
                                software_version = adminEnterVersionBox.Text,
                                description = adminEnterDescriptionBox.Text
                            };
                            BugReportDatabase.VerifiedReports.Add(reportDummy);
                            BugReportDatabase.SaveChanges();
                            adminNarrator.Text = "Your Verified Report has been submitted.";
                        }
                        else
                        {
                            adminNarrator.Text += Environment.NewLine + "Please enter a valid integer for Error Code.";
                        }
                    }
                    else
                    {
                        adminNarrator.Text += Environment.NewLine + "Please enter a description.";
                    }
                }
                else
                {
                    adminNarrator.Text += Environment.NewLine + "Please Enter a software version.";
                }
            }
            else
            {
                adminNarrator.Text += Environment.NewLine + "Please enter an error code.";
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
                            if(iword.Equals(kw.word,StringComparison.Ordinal))
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
