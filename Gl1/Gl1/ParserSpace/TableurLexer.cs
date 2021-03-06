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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class TableurLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		PLUS=1, MINUS=2, MULT=3, DIV=4, MOD=5, AFFECT=6, PAROUV=7, PARFERM=8, 
		AT=9, PV=10, READ=11, DELETE=12, PROPAGE=13, COPY=14, OPEN=15, SAVE=16, 
		EXPORT=17, IMPORT=18, HELP=19, TO=20, INTO=21, QUIT=22, VIRG=23, INT=24, 
		FLOAT=25, FNCTN=26, ADR=27, STRING=28, PATHCSV=29, PATHPROP=30, IGNORE=31;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PLUS", "MINUS", "MULT", "DIV", "MOD", "NUMBER", "LETTER", "AFFECT", "PAROUV", 
		"PARFERM", "AT", "PV", "READ", "DELETE", "PROPAGE", "COPY", "OPEN", "SAVE", 
		"EXPORT", "IMPORT", "HELP", "TO", "INTO", "QUIT", "VIRG", "INT", "FLOAT", 
		"FNCTN", "ADR", "STRING", "PATHCSV", "PATHPROP", "IGNORE"
	};


	public TableurLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TableurLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'-'", "'*'", "'/'", "'mod'", "'<-'", "'('", "')'", "'@'", 
		"';'", "'read'", "'delete'", "'propage'", "'copy'", "'open'", "'save'", 
		"'export'", "'import'", "'help'", "'to'", "'into'", "'quit'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PLUS", "MINUS", "MULT", "DIV", "MOD", "AFFECT", "PAROUV", "PARFERM", 
		"AT", "PV", "READ", "DELETE", "PROPAGE", "COPY", "OPEN", "SAVE", "EXPORT", 
		"IMPORT", "HELP", "TO", "INTO", "QUIT", "VIRG", "INT", "FLOAT", "FNCTN", 
		"ADR", "STRING", "PATHCSV", "PATHPROP", "IGNORE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Tableur.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TableurLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '!', '\xE9', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', 
		'\x6', '\x1B', '\xA7', '\n', '\x1B', '\r', '\x1B', '\xE', '\x1B', '\xA8', 
		'\x3', '\x1C', '\x6', '\x1C', '\xAC', '\n', '\x1C', '\r', '\x1C', '\xE', 
		'\x1C', '\xAD', '\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\xB2', '\n', 
		'\x1C', '\f', '\x1C', '\xE', '\x1C', '\xB5', '\v', '\x1C', '\x3', '\x1D', 
		'\x6', '\x1D', '\xB8', '\n', '\x1D', '\r', '\x1D', '\xE', '\x1D', '\xB9', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\a', '\x1F', '\xC4', '\n', 
		'\x1F', '\f', '\x1F', '\xE', '\x1F', '\xC7', '\v', '\x1F', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x6', ' ', '\xCE', 
		'\n', ' ', '\r', ' ', '\xE', ' ', '\xCF', '\x3', ' ', '\x3', ' ', '\x3', 
		' ', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x6', 
		'!', '\xDA', '\n', '!', '\r', '!', '\xE', '!', '\xDB', '\x3', '!', '\x3', 
		'!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '\"', '\x6', '\"', '\xE4', 
		'\n', '\"', '\r', '\"', '\xE', '\"', '\xE5', '\x3', '\"', '\x3', '\"', 
		'\x2', '\x2', '#', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\x2', '\xF', '\x2', '\x11', '\b', '\x13', '\t', '\x15', 
		'\n', '\x17', '\v', '\x19', '\f', '\x1B', '\r', '\x1D', '\xE', '\x1F', 
		'\xF', '!', '\x10', '#', '\x11', '%', '\x12', '\'', '\x13', ')', '\x14', 
		'+', '\x15', '-', '\x16', '/', '\x17', '\x31', '\x18', '\x33', '\x19', 
		'\x35', '\x1A', '\x37', '\x1B', '\x39', '\x1C', ';', '\x1D', '=', '\x1E', 
		'?', '\x1F', '\x41', ' ', '\x43', '!', '\x3', '\x2', '\x6', '\x3', '\x2', 
		'\x32', ';', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', '\x31', 
		'\x31', '<', '<', '^', '^', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', 
		'\"', '\x2', '\xF4', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\x45', '\x3', '\x2', '\x2', '\x2', '\x5', 'G', '\x3', '\x2', 
		'\x2', '\x2', '\a', 'I', '\x3', '\x2', '\x2', '\x2', '\t', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\v', 'M', '\x3', '\x2', '\x2', '\x2', '\r', 'Q', 
		'\x3', '\x2', '\x2', '\x2', '\xF', 'S', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'U', '\x3', '\x2', '\x2', '\x2', '\x13', 'X', '\x3', '\x2', '\x2', '\x2', 
		'\x15', 'Z', '\x3', '\x2', '\x2', '\x2', '\x17', '\\', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '^', '\x3', '\x2', '\x2', '\x2', '\x1B', '`', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\x65', '\x3', '\x2', '\x2', '\x2', '\x1F', 'l', 
		'\x3', '\x2', '\x2', '\x2', '!', 't', '\x3', '\x2', '\x2', '\x2', '#', 
		'y', '\x3', '\x2', '\x2', '\x2', '%', '~', '\x3', '\x2', '\x2', '\x2', 
		'\'', '\x83', '\x3', '\x2', '\x2', '\x2', ')', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '+', '\x91', '\x3', '\x2', '\x2', '\x2', '-', '\x96', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x99', '\x3', '\x2', '\x2', '\x2', '\x31', '\x9E', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\xA3', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\xA6', '\x3', '\x2', '\x2', '\x2', '\x37', '\xAB', '\x3', '\x2', 
		'\x2', '\x2', '\x39', '\xB7', '\x3', '\x2', '\x2', '\x2', ';', '\xBB', 
		'\x3', '\x2', '\x2', '\x2', '=', '\xBF', '\x3', '\x2', '\x2', '\x2', '?', 
		'\xCD', '\x3', '\x2', '\x2', '\x2', '\x41', '\xD9', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\xE3', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\a', 
		'-', '\x2', '\x2', '\x46', '\x4', '\x3', '\x2', '\x2', '\x2', 'G', 'H', 
		'\a', '/', '\x2', '\x2', 'H', '\x6', '\x3', '\x2', '\x2', '\x2', 'I', 
		'J', '\a', ',', '\x2', '\x2', 'J', '\b', '\x3', '\x2', '\x2', '\x2', 'K', 
		'L', '\a', '\x31', '\x2', '\x2', 'L', '\n', '\x3', '\x2', '\x2', '\x2', 
		'M', 'N', '\a', 'o', '\x2', '\x2', 'N', 'O', '\a', 'q', '\x2', '\x2', 
		'O', 'P', '\a', '\x66', '\x2', '\x2', 'P', '\f', '\x3', '\x2', '\x2', 
		'\x2', 'Q', 'R', '\t', '\x2', '\x2', '\x2', 'R', '\xE', '\x3', '\x2', 
		'\x2', '\x2', 'S', 'T', '\t', '\x3', '\x2', '\x2', 'T', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'U', 'V', '\a', '>', '\x2', '\x2', 'V', 'W', '\a', 
		'/', '\x2', '\x2', 'W', '\x12', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', 
		'\a', '*', '\x2', '\x2', 'Y', '\x14', '\x3', '\x2', '\x2', '\x2', 'Z', 
		'[', '\a', '+', '\x2', '\x2', '[', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'\\', ']', '\a', '\x42', '\x2', '\x2', ']', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '^', '_', '\a', '=', '\x2', '\x2', '_', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '`', '\x61', '\a', 't', '\x2', '\x2', '\x61', '\x62', '\a', 'g', 
		'\x2', '\x2', '\x62', '\x63', '\a', '\x63', '\x2', '\x2', '\x63', '\x64', 
		'\a', '\x66', '\x2', '\x2', '\x64', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'\x65', '\x66', '\a', '\x66', '\x2', '\x2', '\x66', 'g', '\a', 'g', '\x2', 
		'\x2', 'g', 'h', '\a', 'n', '\x2', '\x2', 'h', 'i', '\a', 'g', '\x2', 
		'\x2', 'i', 'j', '\a', 'v', '\x2', '\x2', 'j', 'k', '\a', 'g', '\x2', 
		'\x2', 'k', '\x1E', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', 'r', '\x2', 
		'\x2', 'm', 'n', '\a', 't', '\x2', '\x2', 'n', 'o', '\a', 'q', '\x2', 
		'\x2', 'o', 'p', '\a', 'r', '\x2', '\x2', 'p', 'q', '\a', '\x63', '\x2', 
		'\x2', 'q', 'r', '\a', 'i', '\x2', '\x2', 'r', 's', '\a', 'g', '\x2', 
		'\x2', 's', ' ', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', '\x65', '\x2', 
		'\x2', 'u', 'v', '\a', 'q', '\x2', '\x2', 'v', 'w', '\a', 'r', '\x2', 
		'\x2', 'w', 'x', '\a', '{', '\x2', '\x2', 'x', '\"', '\x3', '\x2', '\x2', 
		'\x2', 'y', 'z', '\a', 'q', '\x2', '\x2', 'z', '{', '\a', 'r', '\x2', 
		'\x2', '{', '|', '\a', 'g', '\x2', '\x2', '|', '}', '\a', 'p', '\x2', 
		'\x2', '}', '$', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', '\a', 'u', '\x2', 
		'\x2', '\x7F', '\x80', '\a', '\x63', '\x2', '\x2', '\x80', '\x81', '\a', 
		'x', '\x2', '\x2', '\x81', '\x82', '\a', 'g', '\x2', '\x2', '\x82', '&', 
		'\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\a', 'g', '\x2', '\x2', '\x84', 
		'\x85', '\a', 'z', '\x2', '\x2', '\x85', '\x86', '\a', 'r', '\x2', '\x2', 
		'\x86', '\x87', '\a', 'q', '\x2', '\x2', '\x87', '\x88', '\a', 't', '\x2', 
		'\x2', '\x88', '\x89', '\a', 'v', '\x2', '\x2', '\x89', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x8A', '\x8B', '\a', 'k', '\x2', '\x2', '\x8B', '\x8C', 
		'\a', 'o', '\x2', '\x2', '\x8C', '\x8D', '\a', 'r', '\x2', '\x2', '\x8D', 
		'\x8E', '\a', 'q', '\x2', '\x2', '\x8E', '\x8F', '\a', 't', '\x2', '\x2', 
		'\x8F', '\x90', '\a', 'v', '\x2', '\x2', '\x90', '*', '\x3', '\x2', '\x2', 
		'\x2', '\x91', '\x92', '\a', 'j', '\x2', '\x2', '\x92', '\x93', '\a', 
		'g', '\x2', '\x2', '\x93', '\x94', '\a', 'n', '\x2', '\x2', '\x94', '\x95', 
		'\a', 'r', '\x2', '\x2', '\x95', ',', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x97', '\a', 'v', '\x2', '\x2', '\x97', '\x98', '\a', 'q', '\x2', '\x2', 
		'\x98', '.', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\a', 'k', '\x2', 
		'\x2', '\x9A', '\x9B', '\a', 'p', '\x2', '\x2', '\x9B', '\x9C', '\a', 
		'v', '\x2', '\x2', '\x9C', '\x9D', '\a', 'q', '\x2', '\x2', '\x9D', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\x9F', '\a', 's', '\x2', '\x2', '\x9F', 
		'\xA0', '\a', 'w', '\x2', '\x2', '\xA0', '\xA1', '\a', 'k', '\x2', '\x2', 
		'\xA1', '\xA2', '\a', 'v', '\x2', '\x2', '\xA2', '\x32', '\x3', '\x2', 
		'\x2', '\x2', '\xA3', '\xA4', '\a', '.', '\x2', '\x2', '\xA4', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\xA5', '\xA7', '\x5', '\r', '\a', '\x2', 
		'\xA6', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', 
		'\x2', '\x2', '\xA8', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', 
		'\x3', '\x2', '\x2', '\x2', '\xA9', '\x36', '\x3', '\x2', '\x2', '\x2', 
		'\xAA', '\xAC', '\x5', '\r', '\a', '\x2', '\xAB', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', '\xAC', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAB', 
		'\x3', '\x2', '\x2', '\x2', '\xAD', '\xAE', '\x3', '\x2', '\x2', '\x2', 
		'\xAE', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB3', '\a', '\x30', 
		'\x2', '\x2', '\xB0', '\xB2', '\x5', '\r', '\a', '\x2', '\xB1', '\xB0', 
		'\x3', '\x2', '\x2', '\x2', '\xB2', '\xB5', '\x3', '\x2', '\x2', '\x2', 
		'\xB3', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', '\x3', '\x2', 
		'\x2', '\x2', '\xB4', '\x38', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB3', 
		'\x3', '\x2', '\x2', '\x2', '\xB6', '\xB8', '\x5', '\xF', '\b', '\x2', 
		'\xB7', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\x3', '\x2', 
		'\x2', '\x2', '\xB9', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', 
		'\x3', '\x2', '\x2', '\x2', '\xBA', ':', '\x3', '\x2', '\x2', '\x2', '\xBB', 
		'\xBC', '\x5', '\x35', '\x1B', '\x2', '\xBC', '\xBD', '\x5', '\x17', '\f', 
		'\x2', '\xBD', '\xBE', '\x5', '\x35', '\x1B', '\x2', '\xBE', '<', '\x3', 
		'\x2', '\x2', '\x2', '\xBF', '\xC5', '\a', '$', '\x2', '\x2', '\xC0', 
		'\xC4', '\x5', '\xF', '\b', '\x2', '\xC1', '\xC4', '\x5', '\r', '\a', 
		'\x2', '\xC2', '\xC4', '\a', '\"', '\x2', '\x2', '\xC3', '\xC0', '\x3', 
		'\x2', '\x2', '\x2', '\xC3', '\xC1', '\x3', '\x2', '\x2', '\x2', '\xC3', 
		'\xC2', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC7', '\x3', '\x2', '\x2', 
		'\x2', '\xC5', '\xC3', '\x3', '\x2', '\x2', '\x2', '\xC5', '\xC6', '\x3', 
		'\x2', '\x2', '\x2', '\xC6', '\xC8', '\x3', '\x2', '\x2', '\x2', '\xC7', 
		'\xC5', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', '\a', '$', '\x2', 
		'\x2', '\xC9', '>', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xCE', '\x5', 
		'\xF', '\b', '\x2', '\xCB', '\xCE', '\x5', '\r', '\a', '\x2', '\xCC', 
		'\xCE', '\t', '\x4', '\x2', '\x2', '\xCD', '\xCA', '\x3', '\x2', '\x2', 
		'\x2', '\xCD', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCC', '\x3', 
		'\x2', '\x2', '\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF', 
		'\xCD', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\x3', '\x2', '\x2', 
		'\x2', '\xD0', '\xD1', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', '\a', 
		'\x30', '\x2', '\x2', '\xD2', '\xD3', '\a', '\x65', '\x2', '\x2', '\xD3', 
		'\xD4', '\a', 'u', '\x2', '\x2', '\xD4', '\xD5', '\a', 'x', '\x2', '\x2', 
		'\xD5', '@', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xDA', '\x5', '\xF', 
		'\b', '\x2', '\xD7', '\xDA', '\x5', '\r', '\a', '\x2', '\xD8', '\xDA', 
		'\t', '\x4', '\x2', '\x2', '\xD9', '\xD6', '\x3', '\x2', '\x2', '\x2', 
		'\xD9', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xD8', '\x3', '\x2', 
		'\x2', '\x2', '\xDA', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xD9', 
		'\x3', '\x2', '\x2', '\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', 
		'\xDC', '\xDD', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\a', '\x30', 
		'\x2', '\x2', '\xDE', '\xDF', '\a', 'k', '\x2', '\x2', '\xDF', '\xE0', 
		'\a', '\x66', '\x2', '\x2', '\xE0', '\xE1', '\a', 'm', '\x2', '\x2', '\xE1', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE4', '\t', '\x5', '\x2', 
		'\x2', '\xE3', '\xE2', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xE5', '\x3', 
		'\x2', '\x2', '\x2', '\xE5', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE5', 
		'\xE6', '\x3', '\x2', '\x2', '\x2', '\xE6', '\xE7', '\x3', '\x2', '\x2', 
		'\x2', '\xE7', '\xE8', '\b', '\"', '\x2', '\x2', '\xE8', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\xE', '\x2', '\xA8', '\xAD', '\xB3', '\xB9', '\xC3', 
		'\xC5', '\xCD', '\xCF', '\xD9', '\xDB', '\xE5', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
