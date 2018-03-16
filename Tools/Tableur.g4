grammar Tableur;

/*
 * Lexer rules
 */

//Arithmetic Operators
PLUS : '+' ;
MINUS : '-' ;
MULT : '*' ;
DIV : '/' ;
MOD : 'mod' ;

//Fragments
fragment NUMBER : [0-9] ;
fragment LETTER :  [a-zA-Z] ;

//Keywords
AFFECT : '<-' ;
PAROUV : '(' ;
PARFERM : ')' ;
AT : '@' ;
PV : ';' ;
READ : 'read' ;
DELETE : 'delete' ;
PROPAGE : 'propage' ; 
COPY : 'copy' ; 
OPEN : 'open' ;
SAVE : 'save' ;
EXPORT : 'export' ;
IMPORT : 'import' ;
HELP : 'help' ;
TO : 'to' ;
INTO : 'into' ;
QUIT : 'quit' ;
VIRG : ',' ;



//Values
INT : NUMBER+ ;
FLOAT : NUMBER+ '.' NUMBER* ;
FNCTN: LETTER+ ;
ADR: INT AT INT ;
STRING : '"' (LETTER | NUMBER | ' ')* '"' ;
PATHCSV : (LETTER | NUMBER | '/' | '\\' | ':')+ '.csv' ;
PATHPROP : (LETTER | NUMBER | '/' | '\\' | ':')+ '.idk' ;
IGNORE : (' ' | '\n' | '\r' | '\t')+ -> skip ;

/*
 * Parser rules
 */

sequence : (instr PV)* EOF;

instr : ADR AFFECT expr #Insert
      | READ ADR #Read
	  | DELETE ADR # Delete
	  | PROPAGE ADR TO ADR #Propage
	  | COPY ADR INTO ADR #Copy
      | SAVE (PATHPROP)? #Save
      | EXPORT (PATHCSV)? #Export
      | OPEN PATHPROP #Open
      | IMPORT PATHCSV #Import
	  | QUIT #Quit
	  | HELP #Help
      ;

expr : expr PLUS multdivmod #Plus
     | expr MINUS multdivmod #Minus
     | multdivmod #ToMult
     ;
		
multdivmod : multdivmod MULT unary  #Mult
        | multdivmod DIV unary #Div
        | multdivmod MOD unary #Mod
        | unary #ToUnary
        ;

unary : MINUS unary #ReverseSign
      | PLUS unary #NotReverse
      | atom #ToAtom
      ;

atom : PAROUV expr PARFERM #Parentheses
	| function #ToFunc
    | ADR  #Reference
	| (FLOAT | INT | STRING)   #Value
    ;


function : FNCTN PAROUV (expr (VIRG expr)*)? PARFERM ;