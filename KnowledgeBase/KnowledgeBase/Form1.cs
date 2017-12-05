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
        private SolvedReport solvedDummy;
        private UnverifiedReport unverDummy;
        private VerifiedReport verifDummy;
        private BindingSource userBi;
        private BindingSource adminBi;
        private BindingSource devBi;



        public Form1()
        {
            InitializeComponent();
            BugReportDatabase = new KnowledgeBaseEntities();
            solvedDummy = new SolvedReport();
            unverDummy = new UnverifiedReport();
            userBi = new BindingSource();
            adminBi = new BindingSource();
            devBi = new BindingSource();

            BugReportDatabase.Administrators.Add(new Administrator
            {
                username = "Eric",
                password = "password1"
            });//Eric, password1

            BugReportDatabase.Developers.Add(new Developer
            {
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
                word = "Stack"
            });//Stack
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "contextMap"
            });//contextMap
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "declares"
            });//declares
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "hashcode()"
            });//hashcode()
            BugReportDatabase.Keywords.Add(new Keyword
            {
                word = "error"
            });//error
            
            BugReportDatabase.SolvedReports.Add(new SolvedReport
            {
                error_code = 407017,
                software_version = "1.1.1",
                description = "In org.aspectj.ajdt.internal.core.builder.AjState.getDelegate(ReferenceType), there is a call to printStackTrace(). On the AJDT build server, this exception is being printed and causing some noise.",
                solution = "Bug 407017 Stack trace being printed, but want to mute it."
            });//14,394535,contextMap,CompilationAndWeavingContext,Thread
            BugReportDatabase.SolvedReports.Add(new SolvedReport
            {
                error_code = 39993,
                software_version = "1.1.2",
                description = "When an AspectJ thread declares hashcode(), throws unknown exception",
                solution = "package-level abstract generic privileged aspect, which extends an abstract generic aspect, gives a IllegalStateException on a method call"
            });
            BugReportDatabase.SaveChanges();
            adminSearchButton.Enabled = false;
            adminSubmitButton.Enabled = false;
            adminDeleteButton.Enabled = false;
            devSearchButton.Enabled = false;
            devSubmitButton.Enabled = false;
            devDeleteButton.Enabled = false;
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
                            solvedDummy.error_code = codeDummy;
                            solvedDummy.software_version = userEnterVersionBox.Text;
                            solvedDummy.description = userEnterDescriptionBox.Text;
                            userSubmitButton.Enabled = true;
                            var userDisplay = BugReportDatabase.SolvedReports
                                .Where(s =>s.error_code == solvedDummy.error_code ||
                                s.software_version.Equals(solvedDummy.software_version, StringComparison.Ordinal)||
                                matchKeywords(solvedDummy.description, s.description) >= 5);//find any matching Error Code, version, or description with more than 5 matching keywords
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
                            
                            unverDummy.error_code = codeDummy;
                            unverDummy.software_version = adminEnterVersionBox.Text;
                            unverDummy.description = adminEnterDescriptionBox.Text;
                            adminSubmitButton.Enabled = true;
                            var adminDisplay = BugReportDatabase.UnverifiedReports
                                .Where(u => u.error_code == unverDummy.error_code ||
                                u.software_version.Equals(unverDummy.software_version, StringComparison.Ordinal) ||
                                matchKeywords(u.description, unverDummy.description) >= 5);
                            
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
                            verifDummy = new VerifiedReport
                            {
                                error_code = codeDummy,
                                software_version = adminEnterVersionBox.Text,
                                description = adminEnterDescriptionBox.Text
                            };
                            BugReportDatabase.VerifiedReports.Add(verifDummy);
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

        private void adminDeleteButton_Click(object sender, EventArgs e)
        {
            int codeDummy;
            if (!string.IsNullOrEmpty(adminEnterErrorCodeBox.Text))
            {
                if (!string.IsNullOrEmpty(adminEnterVersionBox.Text))
                {
                    if (int.TryParse(adminEnterErrorCodeBox.Text, out codeDummy))
                    {
                        UnverifiedReport x = (UnverifiedReport)from y in BugReportDatabase.UnverifiedReports
                                                               where y.error_code == codeDummy && y.software_version.Equals(adminEnterVersionBox.Text, StringComparison.Ordinal)
                                                               select y;
                        if (x != null)
                        {
                            BugReportDatabase.UnverifiedReports.Remove(x);
                            BugReportDatabase.SaveChanges();
                            adminNarrator.Text += Environment.NewLine + "Your report has been removed from Unverified.";
                        }
                        else
                        {
                            adminNarrator.Text = "That report does not exist.";
                        }
                    }
                    else
                    {
                        adminNarrator.Text += Environment.NewLine + "Please enter a valid integer for Error Code.";
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
                            verifDummy.error_code = codeDummy;
                            verifDummy.software_version = devEnterVersionBox.Text;
                            verifDummy.description = devEnterDescriptionBox.Text;
                            devSubmitButton.Enabled = true;
                            var devDisplay = BugReportDatabase.VerifiedReports
                                .Where(v => v.error_code == verifDummy.error_code ||
                                v.software_version.Equals(verifDummy.software_version, StringComparison.Ordinal) ||
                                matchKeywords(v.description, verifDummy.description) >= 5);
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

        private void devSubmitButton_Click(object sender, EventArgs e)
        {
            int codeDummy;
            if(!string.IsNullOrEmpty(devEnterErrorCodeBox.Text))
            {
                if(!string.IsNullOrEmpty(devEnterVersionBox.Text))
                {
                    if(!string.IsNullOrEmpty(devEnterDescriptionBox.Text))
                    {
                        if(!string.IsNullOrEmpty(devEnterSolutionBox.Text))
                        {
                            if(int.TryParse(devEnterSolutionBox.Text, out codeDummy))
                            {
                                SolvedReport reportDummy = new SolvedReport
                                {
                                    error_code = codeDummy,
                                    software_version = devEnterVersionBox.Text,
                                    description = devEnterDescriptionBox.Text,
                                    solution = devEnterSolutionBox.Text
                                };
                                BugReportDatabase.SolvedReports.Add(reportDummy);
                                BugReportDatabase.SaveChanges();
                                devNarrator.Text = "Your Solved Report has been submitted.";
                            }
                            else
                            {
                                devNarrator.Text += Environment.NewLine + "Please Enter a valid integer for Error Code.";
                            }
                        }
                        else
                        {
                            devNarrator.Text += Environment.NewLine + "Please enter a solution.";
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
                devNarrator.Text += Environment.NewLine + "Please enter an Error Code.";
            }
        }

        private void devDeleteButton_Click(object sender, EventArgs e)
        {
            int codeDummy;
            if(!string.IsNullOrEmpty(devEnterErrorCodeBox.Text))
            {
                if(!string.IsNullOrEmpty(devEnterVersionBox.Text))
                {
                    if(int.TryParse(devEnterErrorCodeBox.Text, out codeDummy))
                    {
                        VerifiedReport x = (VerifiedReport)from y in BugReportDatabase.VerifiedReports
                                                           where y.error_code == codeDummy && y.software_version.Equals(devEnterVersionBox.Text, StringComparison.Ordinal)
                                                           select y;
                        if(x != null)
                        {
                            BugReportDatabase.VerifiedReports.Remove(x);
                            BugReportDatabase.SaveChanges();
                            devNarrator.Text += Environment.NewLine + "Your report has been removed from Verified.";
                        }
                        else
                        {
                            devNarrator.Text = "That report does not exist";
                        }
                    }
                    else
                    {
                        devNarrator.Text += Environment.NewLine + "Please enter a valid integer for Error Code.";
                    }
                }
                else
                {
                    devNarrator.Text += Environment.NewLine + "Please enter a software version.";
                }
            }
            devNarrator.Text += Environment.NewLine + "Please enter an error code.";
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
                    var findDev = BugReportDatabase.Developers
                        .Where(d => (d.username.Equals(uname, StringComparison.Ordinal)) && (d.password.Equals(pword, StringComparison.Ordinal)))
                        .Select(d => new { d.username, d.password });
                        //find any devs in the database with that uname and pword

                    if (findAdmin != null)//if it found any match
                    {
                        adminSearchButton.Enabled = true;
                        adminSubmitButton.Enabled = true;
                        adminDeleteButton.Enabled = true;
                    }
                    else if(findDev != null)
                    {
                        devSearchButton.Enabled = true;
                        devSubmitButton.Enabled = true;
                        devDeleteButton.Enabled = true;
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
