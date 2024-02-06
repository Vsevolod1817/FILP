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

grand_ma_and_son(X,Y):-man(X),woman(Y),parent(Z,X),parent(Y,Z).
grand_ma_and_son(X,Y):-woman(X),man(Y),parent(Z,Y),parent(X,Z).
