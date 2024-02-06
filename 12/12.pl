sum(X,X):- X<10,!.
sum(X,Y):- X1 is X  div 10, sum(X1,Y1),Y is (X mod 10)+Y1.

proiz_up(X,Y):- proiz_up(X,Y,1).

proiz_up(X,1,X):-  !.

proiz_up(X,Y,I):-(X mod I) =:=  0, sum_dig(I,Z1), sum_dig(X,Z2),Z1<Z2,
                                     I1 is I+1 ,proiz_up(X,Y1,I1), Y  is Y1*I.

proiz_up(X,Y,I):- I1 is I+1, proiz_up(X,Y1,I1), Y  is Y1.

proiz_down(X,Y):- proiz_down(X,Y,1,1).

proiz_down(X,Y,Acc,X):- Y is Acc,!.

proiz_down(X,Y,Acc,I):-I<X, X mod I=:= 0,
                                 sum_dig(I,Z1), sum_dig(X,Z2),Z1<Z2,
                                I1 is I+1,Acc1 is  Acc*I,proiz_down(X,Y,Acc1,I1).

proiz_down(X,Y,Acc,I):- I<X, I1 is I+1,proiz_down(X,Y,Acc,I1).
