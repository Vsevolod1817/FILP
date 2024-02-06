list_length([],L):- write(L),!.
list_length([_|T],L):-X1 is L+1, list_length(T,X1).
list_length([H|T]):-list_length([H|T],0).
