man(витя).
man(вова).
man(сева).
man(сергей).

woman(света).
woman(нина).
woman(алина).
woman(кристина).
woman(олеся).

parent(витя,нина).
parent(вова,алина).
parent(сева,кристина).
parent(сергей,витя).
parent(алина,света).
parent(сергей,алина).
parent(кристина,вова).
parent(олеся,кристина).

grand_so(X,Y):-man(X),parent(Z,X),parent(Y,Z).
grand_sons(X):-man(Y),parent(Z,Y),parent(X,Z),write(Y).
