mult_up(X,Y):-X<10, Y is X.
mult_up(X,Y):-X1 is (X div 10),mult_up(X1,Y1),Y is (X mod 10)*Y1.
mult_up(X):-mult_up(X,Y),write(Y).
