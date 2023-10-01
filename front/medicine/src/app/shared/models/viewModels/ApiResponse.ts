export class ApiResponse<T>{
  Error: boolean = false
  Message?: string;
  Errors?: string[];
  PayLoad!: T;
}

export class JsonResult
{
  contentType: string | null | undefined;
  serializerSettings: any | null | undefined; // Use a more specific type if possible
  statusCode: number | null | undefined;
  value: any | null | undefined; // Use a more spec
}