mult_down(0,Y):-write(Y).
mult_down(X,Y):-X1 is (X div 10), Y1 is (X mod 10)*Y, mult_down(X1,Y1).
mult_down(X):-mult_down(X,1).
