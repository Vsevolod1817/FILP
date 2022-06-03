evenQ([H|T]):-evenQ([H|T],0).

evenQ([],Q):-write(Q).

evenQ([H|T],Q):-
	H mod 2 =:= 0,
	N_Q is Q + 1,
	evenQ(T,N_Q);
	evenQ(T,Q).
