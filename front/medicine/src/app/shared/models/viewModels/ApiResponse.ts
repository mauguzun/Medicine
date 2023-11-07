export class ApiResponse<T>{
  constructor(public Message: T) { }
}

export class TupleReponse<T,T1>{
  constructor(public Item1: T,public Item2:T1) { }
}


export class GqlResponse<T>{
  constructor(public find: T) { }
}