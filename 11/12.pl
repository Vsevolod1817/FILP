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
parent(сергей,алина).
parent(кристина,вова).

sister(X,Y):-parent(Z,X),parent(Z,Y),parent(D,Y), parent(D,X), woman(Y), woman(Z),man(D).
sister(X):-parent(Z,X), parent(Z,Y),parent(D,X),parent(D,Y), woman(Y), woman(Z), man(D), write(Y).
