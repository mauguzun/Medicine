export class ApiResponse<T>{
  Error: boolean = false
  Message?: string;
  Errors?: string[];
  PayLoad!: T;
}

