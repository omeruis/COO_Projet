using Antlr4.Runtime;
using Aosk.TermSpace;
using Aosk.Exceptions;
using System;
using System.IO;

namespace Aosk.ParserSpace
{
    /// <summary>
    /// Classe gerant les interactions avec l'utilisateur
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// Analyse la saisie utilisateur, après découpage de la saisie fait appelle vers les méthodes de la classe Kernel si la saisie est valide.
        /// </summary>
        /// <param name="saisie">La chaine de caracteres rentree par l'utilisateur</param>
        /// <returns>Le resultat de l'analyse pour effecteur le traitement</returns>
        public String Analyse(string saisie)
        {
            ICharStream stream = CharStreams.fromstring(saisie);

            //Passe la chaine aux classes Antlr4 pour créer l'arbre syntaxique
            TableurLexer tableurLexer = new TableurLexer(stream);
            tableurLexer.RemoveErrorListener(ConsoleErrorListener<int>.Instance);
            tableurLexer.AddErrorListener(new ErrorLexerListener());
            CommonTokenStream commonTokenStream = new CommonTokenStream(tableurLexer);
            TableurParser tableurParser = new TableurParser(commonTokenStream);
            tableurParser.RemoveErrorListener(ConsoleErrorListener<IToken>.Instance);
            tableurParser.AddErrorListener(new ErrorParserListener());


            TableurParser.SequenceContext expressionContext = tableurParser.sequence();

            //Visite de l'arbre pour faire l'execution des commandes
            Term resul = this.visitor.Visit(expressionContext);
            return resul.ToString();

        }

        /// <summary>
        /// Constructeur de la classe Parser. 
        /// </summary>
        /// <param name="kern">Noyau fonctionel en lien avec le parseur</param>
        /// <see cref="Kernel"/>
        public Parser(Kernel kern)
        {
            this.visitor = new AnalyseVisitor(kern);
        }

        /// <summary>
        /// Classe permettant d'envoyer une erreur de notre application lors d'un probleme lie au lexer
        /// </summary>
        private class ErrorLexerListener : IAntlrErrorListener<int>
        {
            public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new GrammarException();
            }
        }


        /// <summary>
        /// Classe permettant d'envoyer une erreur de notre application lors d'un probleme lie au parser
        /// </summary>
        private class ErrorParserListener : IAntlrErrorListener<IToken>
        {
            public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new GrammarException();
            }
        }

        /// <summary>
        /// Visiteur de l'arbre genere par les classes Antlr4
        /// </summary>
        private AnalyseVisitor visitor;
    }
}