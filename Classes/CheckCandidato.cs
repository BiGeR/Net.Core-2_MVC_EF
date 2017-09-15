using System;
using MeusPedidos_Brunno.Models;

namespace MeusPedidos_Brunno.Classes
{
    public class CheckCandidato
    {
        public bool CheckSkills(Candidato candidato)
        {
            try
            {
                //Verificar Todos
                if (candidato.Html >= 7 && candidato.Javascript >= 7 && candidato.Css >= 7)
                {
                    if (candidato.Python >= 7 && candidato.Django >= 7)
                    {
                        if (candidato.Android >= 7 && candidato.Ios >= 7)
                        {
                            //Aprovado em todas os testes.
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Front-End entraremos em contato", "frontend@meuspedidos.com.br");
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Back-End entraremos em contato", "backend@meuspedidos.com.br");
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Mobile entraremos em contato", "mobile@meuspedidos.com.br");

                            return true;
                        }
                        else
                        {
                            //Aprovado em Back e Front
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Front-End entraremos em contato", "frontend@meuspedidos.com.br");
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Back-End entraremos em contato", "backend@meuspedidos.com.br");

                            return true;
                        }
                    }
                    else
                    {
                        //Verificar Mobile
                        if (candidato.Android >= 7 && candidato.Ios >= 7)
                        {
                            //Aprovado em Front-End + Mobile
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Front-End entraremos em contato", "frontend@meuspedidos.com.br");
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Mobile entraremos em contato", "mobile@meuspedidos.com.br");

                            return true;
                        }
                        else
                        {
                            //Aprovado em Front-End
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Front-End entraremos em contato", "frontend@meuspedidos.com.br");
                        }
                        
                    }
                }
                else
                {
                    //Verificar back-end + mobile
                    if (candidato.Python >= 7 && candidato.Django >= 7)
                    {
                        if (candidato.Android >= 7 && candidato.Ios >= 7)
                        {
                            //Aprovado em Back-end + Mobile
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Back-End entraremos em contato", "backend@meuspedidos.com.br");
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Mobile entraremos em contato", "mobile@meuspedidos.com.br");
                            return true;
                        }
                        else
                        {
                            //Aprovado em Back-End
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Back-End entraremos em contato", "backend@meuspedidos.com.br");
                        }
                            
                    }
                    else
                    {
                        //Verificar Mobile
                        if (candidato.Android >= 7 && candidato.Ios >= 7)
                        {
                            //Aprovado em Mobile
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador " +
                                "Mobile entraremos em contato", "mobile@meuspedidos.com.br");
                        }
                        else
                        {
                            //Reprovado em Todos
                            MailSystem mail = new MailSystem();
                            mail.CreateSMTPMail("localhost", "Reprovado, Teste Reprovado!!!", "reprovado@meuspedidos.com.br");
                        }
                    }
                }
                
              

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in check skills from Candidato(): {0}",ex.ToString());
            }
            return false;
        }
    }
}
