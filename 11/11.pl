man(витя).
man(вова).
man(сева).
man(сергей).

woman(света).
woman(нина).
woman(алина).
woman(кристина).

parent(витя,нина).
parent(вова,алина).
parent(сева,кристина).
parent(сергей,витя).
parent(алина,света).

father(X,Y):-man(X),parent(X,Y).
father(X):-man(Y), parent(Y,X), write(Y).
