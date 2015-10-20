: iota ( s n -- numbers )
  dup 1 = 
  IF     drop 
  ELSE   swap dup 1+ rot 1- iota 
  THEN ;

