appenD([], List, List).
appenD([Head|Tail], List, [Head|ResultTail]):-
    appenD(Tail, List, ResultTail).

writeList([]):-!.
writeList([H|T]):-write(H),nl,writeList(T).

segment([],_,_,ACC):-writeList(ACC).

segment([H|T],A,B,ACC):-
	H >= A,
	H =< B,
	appenD(ACC,[H],N_ACC),
	segment(T,A,B,N_ACC);
	segment(T,A,B,ACC).

segment([H|T],A,B):- segment([H|T],A,B,[]).
