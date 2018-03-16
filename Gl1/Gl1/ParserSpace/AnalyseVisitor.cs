using System;
using Antlr4.Runtime.Misc;
using Aosk.TermSpace;
using Aosk.TermSpace.TypeValeurs;
using Aosk.CellSpace;
using Aosk.TermSpace.Operateur;
using Antlr4.Runtime.Tree;
using Aosk.TermSpace.Fonctions.Numerique;
using Aosk.Exceptions;

namespace Aosk.ParserSpace
{
    /// <summary>
    /// Classe de visiteur permettant d'executer les commandes envoyes au parser
    /// </summary>
    class AnalyseVisitor : TableurBaseVisitor<Term>
    {
        /// <summary>
        /// Constructeur du visiteur
        /// </summary>
        /// <param name="kernel">Le noyau fonctionnel de l'application</param>
        public AnalyseVisitor(Kernel kernel)
        {
            this.kern = kernel;
        }

        /// <summary>
        /// Execute la sequence d'instruction
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>le resultat de la derniere instruction</returns>
        public override Term VisitSequence([NotNull] TableurParser.SequenceContext context)
        {
            String res = "";
            foreach (TableurParser.InstrContext curr in context.instr())
            {
                res = this.Visit(curr).ToString();
            }
            return new Texte(res);
        }
        
        /// <summary>
        /// Execute l'insertion d'une expression dans une cellule
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitInsert([NotNull] TableurParser.InsertContext context)
        {
            //recupere l'adresse puis insere l'expression dans la cellule
            String adr = context.ADR().GetText();
            String[] cur = adr.Split('@');
            CellCoord target = new CellCoord(ulong.Parse(cur[0]), ulong.Parse(cur[1]));
            String val = context.expr().GetText();
            this.kern.InsertData(target, this.Visit(context.expr()));
            return new Texte("Insert Success");
        }

        /// <summary>
        /// Execute la copie d'une cellule dans une autre
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitCopy([NotNull] TableurParser.CopyContext context)
        {

            //recupere l'adresse de la source et de la cible
            ITerminalNode[] adr = context.ADR();
            String adr1 = adr[0].GetText();
            String adr2 = adr[1].GetText();
            String[] targetSplit = adr2.Split('@');
            String[] srcSplit = adr1.Split('@');

            CellCoord target = new CellCoord(ulong.Parse(targetSplit[0]), ulong.Parse(targetSplit[1]));
            CellCoord src = new CellCoord(ulong.Parse(srcSplit[0]), ulong.Parse(srcSplit[1]));
            //copie
            this.kern.CopyData(target, src);
            return new Texte("Copy Success");
        }

        /// <summary>
        /// Execute la propagation d'une cellule sur une plage de cellules
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitPropage([NotNull] TableurParser.PropageContext context)
        {
            ITerminalNode[] adr = context.ADR();
            String adr1 = adr[0].GetText();
            String adr2 = adr[1].GetText();
            String[] targetSplit = adr2.Split('@');
            String[] srcSplit = adr1.Split('@');

            CellCoord target = new CellCoord(ulong.Parse(targetSplit[0]), ulong.Parse(targetSplit[1]));
            CellCoord src = new CellCoord(ulong.Parse(srcSplit[0]), ulong.Parse(srcSplit[1]));
            this.kern.Propage(target, src);
            return new Texte("Propage Success");
        }

        /// <summary>
        /// Supprime une celllule du tableur
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitDelete([NotNull] TableurParser.DeleteContext context)
        {
            String adr = context.ADR().GetText();
            String[] cur = adr.Split('@');
            CellCoord target = new CellCoord(ulong.Parse(cur[0]), ulong.Parse(cur[1]));
            this.kern.DeleteContent(target);
            return new Texte("Delete Success");
        }

        /// <summary>
        /// Quitte l'application
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message Exit</returns>
        public override Term VisitQuit([NotNull] TableurParser.QuitContext context)
        {
            return new Texte("Exit");
        }

        /// <summary>
        /// Interprete l'expression d'une cellule
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le resultat de l'expression de la cellule cible</returns>
        public override Term VisitRead([NotNull] TableurParser.ReadContext context)
        {
            String adr = context.ADR().GetText();
            String[] cur = adr.Split('@');
            CellCoord target = new CellCoord(ulong.Parse(cur[0]), ulong.Parse(cur[1]));
            String msg = this.kern.Read(target);
            return new Texte(msg);
        }

        /// <summary>
        /// Execute la sauvegarde dans un fichier au format idk
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitSave([NotNull] TableurParser.SaveContext context)
        {
            if (context.PATHPROP()!=null)
            {
                String path = context.PATHPROP().GetText();
                this.kern.Save(path);
            } else
            {
                this.kern.Save();
            }
            return new Texte("Save Success");
        }

        /// <summary>
        /// Execute l'export dans un fichier csv
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitExport([NotNull] TableurParser.ExportContext context)
        {
            if (context.PATHCSV() != null)
            {
                String path = context.PATHCSV().GetText();
                this.kern.Export(path);
            }
            else
            {
                this.kern.Export();
            }
            return new Texte("Export Success");
        }


        /// <summary>
        /// Execute l'ouverture d'un fichier en format idk
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitOpen([NotNull] TableurParser.OpenContext context)
        {
            String path = context.PATHPROP().GetText();
            this.kern.Open(path);
            return new Texte("Open Success");
        }

        /// <summary>
        /// Execute l'import d'un fichier en format csv
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un message de confirmation</returns>
        public override Term VisitImport([NotNull] TableurParser.ImportContext context)
        {
            String path = context.PATHCSV().GetText();
            this.kern.Import(path);
            return new Texte("Import Success");
        }

        /// <summary>
        /// Creer un Terme 'Plus' qui s'applique sur sur les termes renvoyés par les non-terminaux a gauche et a droite du symbole
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'Plus' avec ses fils places</returns>
        public override Term VisitPlus([NotNull] TableurParser.PlusContext context)
        {
            Term[] vars = new Term[2];
            vars[0] = this.Visit(context.expr());
            vars[1] = this.Visit(context.multdivmod());
            return new Plus(vars);
        }

        /// <summary>
        /// Creer un Terme 'Minus' qui s'applique sur sur les termes renvoyés par les non-terminaux a gauche et a droite du symbole
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'Minus' avec ses fils places</returns>
        public override Term VisitMinus([NotNull] TableurParser.MinusContext context)
        {
            Term[] vars = new Term[2];
            vars[0] = this.Visit(context.expr());
            vars[1] = this.Visit(context.multdivmod());
            return new Minus(vars);
        }

        /// <summary>
        /// Permet d'aller a la regle Funcion de la grammaire
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme remonte par la visite de la regle Function</returns>
        public override Term VisitToFunc([NotNull] TableurParser.ToFuncContext context)
        {
            return this.VisitFunction(context.function());
        }

        /// <summary>
        /// Permet d'aller a la regle Mult de la grammaire
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme remonte par la visite de la regle Mult</returns>
        public override Term VisitToMult([NotNull] TableurParser.ToMultContext context)
        {
            return this.Visit(context.multdivmod());
        }

        /// <summary>
        /// Creer un Terme 'Mult' qui s'applique sur sur les termes renvoyés par les non-terminaux a gauche et a droite du symbole
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'Mult' avec ses fils places</returns>
        public override Term VisitMult([NotNull] TableurParser.MultContext context)
        {
            Term[] vars = new Term[2];
            vars[0] = this.Visit(context.multdivmod());
            vars[1] = this.Visit(context.unary());
            return new Mult(vars); ;
        }

        /// <summary>
        /// Creer un Terme 'Div' qui s'applique sur sur les termes renvoyés par les non-terminaux a gauche et a droite du symbole
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'Div' avec ses fils places</returns>
        public override Term VisitDiv([NotNull] TableurParser.DivContext context)
        {
            Term[] vars = new Term[2];
            vars[0] = this.Visit(context.multdivmod());
            vars[1] = this.Visit(context.unary());
            return new Div(vars); ;
        }

        /// <summary>
        /// Creer un Terme 'Moodulo' qui s'applique sur sur les termes renvoyés par les non-terminaux a gauche et a droite du symbole
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'Modulo' avec ses fils places</returns>
        public override Term VisitMod([NotNull] TableurParser.ModContext context)
        {
            Term[] vars = new Term[2];
            vars[0] = this.Visit(context.multdivmod());
            vars[1] = this.Visit(context.unary());
            return new Modulo(vars); ;
        }

        /// <summary>
        /// Permet d'aller a la regle Unary de la grammaire
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme remonte par la visite de la regle Unary</returns>
        public override Term VisitToUnary([NotNull] TableurParser.ToUnaryContext context)
        {
            return this.Visit(context.unary());
        }

        /// <summary>
        /// Creer un Terme 'UnaryMinus' qui permet d'inverser le signe du resultat sur lequel s'applique le '-'
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'UnaryMinus' avec son fils place</returns>
        public override Term VisitReverseSign([NotNull] TableurParser.ReverseSignContext context)
        {
            Term[] toApply = new Term[1];
            toApply[0] = this.Visit(context.unary());
            return new UnaryMinus(toApply);
        }

        /// <summary>
        /// Creer un Terme 'UnaryPlus' qui permet l'ecriture d'expression comme '+5'
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'UnaryPlus' avec son fils place</returns>
        public override Term VisitNotReverse([NotNull] TableurParser.NotReverseContext context)
        {
            Term[] toApply = new Term[1];
            toApply[0] = this.Visit(context.unary());
            return new UnaryPlus(toApply);
        }

        /// <summary>
        /// Permet d'aller a la regle Atom de la grammaire
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme remonte par la visite de la regle Atom</returns>
        public override Term VisitToAtom([NotNull] TableurParser.ToAtomContext context)
        {
            return this.Visit(context.atom());
        }

        /// <summary>
        /// Permet de donner la priorite des parentheses
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>le Terme remonte par la visite de l'expression entre parentheses</returns>
        public override Term VisitParentheses([NotNull] TableurParser.ParenthesesContext context)
        {
            return this.Visit(context.expr());
        }

        /// <summary>
        /// Creer un Terme 'Reference' qui permet de referencer une cellule dans un expression
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Le Terme 'Reference' qui reference une cellule du tableur</returns>
        public override Term VisitReference([NotNull] TableurParser.ReferenceContext context)
        {
            String adr = context.ADR().GetText();
            String[] cur = adr.Split('@');
            CellCoord target = new CellCoord(ulong.Parse(cur[0]), ulong.Parse(cur[1]));
            try
            {
                Cell referenced = this.kern.searchCell(target);
                return new References(referenced);
            }
            catch (Exception e)
            {
                return new Texte(e.Message);
            }
        }

        /// <summary>
        /// Creer un Terme correspondant a la valeur du terminal non null
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un Terme numerique si c'est un entier ou flottant. Un terme Texte si c'est une string</returns>
        public override Term VisitValue([NotNull] TableurParser.ValueContext context)
        {
            if (context.INT() != null)
            {
                return new Numeric(context.INT().GetText());
            }
            else if (context.FLOAT() != null)
            {
                return new Numeric(context.FLOAT().GetText());
            }
            else if (context.STRING() != null)
            {
                String str = context.STRING().GetText();
                str = str.Substring(1, str.Length - 2);
                return new Texte(str);
            }
            else
            {
                throw new GrammarException();
            }
        }

        /// <summary>
        /// Creer La fonction correspondant a l'identifiant ecrit
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un Terme representant la fonction ecrite avec ses parametre places</returns>
        public override Term VisitFunction([NotNull] TableurParser.FunctionContext context)
        {
            string func = context.FNCTN().GetText();
            TableurParser.ExprContext[] param = context.expr();
            Term[] vars = new Term[param.Length];
            int i = 0;
            foreach (TableurParser.ExprContext curr in param)
            {
                vars[i] = this.Visit(curr);
                i++;
            }
            return Operation.createFunc(func, vars);
        }

        /// <summary>
        /// Execute la commande de manuel de l'application
        /// </summary>
        /// <param name="context">la partie droite de la regle de la grammaire</param>
        /// <returns>Un Termne contenant l'aide</returns>
        public override Term VisitHelp([NotNull] TableurParser.HelpContext context)
        {
            return new Texte(this.kern.help());
        }

        /// <summary>
        /// Le noyau fonctionnel de l'application
        /// </summary>
        private Kernel kern;
    }
}
