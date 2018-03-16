# COO_Projet AOSK
 
Le programme a été écrit en C# avec l'IDE Visual Studio.

La grammaire a été écrite avec Antlr4 et le fichier de la grammaire se trouve dans le dossier Tools.

Le fichier help.txt dans le dossier Gl1/Doc contient les explications sur l'utilisation du programme (peut aussi être affiché avec la commande help; lorsque le programme est lancé).



Pour tester la grammaire à part du programme :
	
	Ouvrir une console cmd Windows.

	Aller dans le dossier Tools

	Entrer : classpath

	Entrer : antlr4 Tableur.g4

	Entrer : javac Tableur*.java

	Entrer : grun Tableur sequence -gui

	Entrer les phrases que vous voulez tester.

	Faire Ctrl-Z puis Entree pour arreter le parsing et faire afficher l'arbre.