countDig(0,0):-!.
countDig(X,Y):- X1 is X div 10, P is X mod 10,
    countDig(X1,Y1), (P>3,P mod 2 =\=0 -> Y is Y1+1;Y is Y1).
countDig(X):-countDig(X,Y),write(Y).
