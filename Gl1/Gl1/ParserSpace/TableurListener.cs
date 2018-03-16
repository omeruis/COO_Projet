//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Tableur.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="TableurParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface ITableurListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TableurParser.sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSequence([NotNull] TableurParser.SequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TableurParser.sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSequence([NotNull] TableurParser.SequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Insert</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert([NotNull] TableurParser.InsertContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Insert</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert([NotNull] TableurParser.InsertContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRead([NotNull] TableurParser.ReadContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRead([NotNull] TableurParser.ReadContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Delete</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete([NotNull] TableurParser.DeleteContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Delete</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete([NotNull] TableurParser.DeleteContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Propage</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropage([NotNull] TableurParser.PropageContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Propage</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropage([NotNull] TableurParser.PropageContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Copy</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy([NotNull] TableurParser.CopyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Copy</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy([NotNull] TableurParser.CopyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Save</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSave([NotNull] TableurParser.SaveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Save</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSave([NotNull] TableurParser.SaveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Export</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExport([NotNull] TableurParser.ExportContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Export</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExport([NotNull] TableurParser.ExportContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Open</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpen([NotNull] TableurParser.OpenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Open</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpen([NotNull] TableurParser.OpenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Import</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImport([NotNull] TableurParser.ImportContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Import</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImport([NotNull] TableurParser.ImportContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Quit</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuit([NotNull] TableurParser.QuitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Quit</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuit([NotNull] TableurParser.QuitContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Help</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHelp([NotNull] TableurParser.HelpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Help</c>
	/// labeled alternative in <see cref="TableurParser.instr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHelp([NotNull] TableurParser.HelpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ToMult</c>
	/// labeled alternative in <see cref="TableurParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterToMult([NotNull] TableurParser.ToMultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ToMult</c>
	/// labeled alternative in <see cref="TableurParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitToMult([NotNull] TableurParser.ToMultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Plus</c>
	/// labeled alternative in <see cref="TableurParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlus([NotNull] TableurParser.PlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Plus</c>
	/// labeled alternative in <see cref="TableurParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlus([NotNull] TableurParser.PlusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="TableurParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMinus([NotNull] TableurParser.MinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="TableurParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMinus([NotNull] TableurParser.MinusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Div</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiv([NotNull] TableurParser.DivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Div</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiv([NotNull] TableurParser.DivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ToUnary</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterToUnary([NotNull] TableurParser.ToUnaryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ToUnary</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitToUnary([NotNull] TableurParser.ToUnaryContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMod([NotNull] TableurParser.ModContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMod([NotNull] TableurParser.ModContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMult([NotNull] TableurParser.MultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="TableurParser.multdivmod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMult([NotNull] TableurParser.MultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ReverseSign</c>
	/// labeled alternative in <see cref="TableurParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReverseSign([NotNull] TableurParser.ReverseSignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ReverseSign</c>
	/// labeled alternative in <see cref="TableurParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReverseSign([NotNull] TableurParser.ReverseSignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NotReverse</c>
	/// labeled alternative in <see cref="TableurParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotReverse([NotNull] TableurParser.NotReverseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NotReverse</c>
	/// labeled alternative in <see cref="TableurParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotReverse([NotNull] TableurParser.NotReverseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ToAtom</c>
	/// labeled alternative in <see cref="TableurParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterToAtom([NotNull] TableurParser.ToAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ToAtom</c>
	/// labeled alternative in <see cref="TableurParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitToAtom([NotNull] TableurParser.ToAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Parentheses</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentheses([NotNull] TableurParser.ParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parentheses</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentheses([NotNull] TableurParser.ParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ToFunc</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterToFunc([NotNull] TableurParser.ToFuncContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ToFunc</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitToFunc([NotNull] TableurParser.ToFuncContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Reference</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference([NotNull] TableurParser.ReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Reference</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference([NotNull] TableurParser.ReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Value</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] TableurParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Value</c>
	/// labeled alternative in <see cref="TableurParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] TableurParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TableurParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] TableurParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TableurParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] TableurParser.FunctionContext context);
}
