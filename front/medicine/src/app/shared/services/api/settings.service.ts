import { Injectable } from '@angular/core';
import { environment } from "src/assets/environments/environment";
import { HttpClient, HttpErrorResponse, HttpResponse } from "@angular/common/http";
import { catchError, map } from "rxjs/operators";
import { ApiResponse } from "../../models/viewModels/ApiResponse";
import { UserSettingsDto } from "../../models/viewModels/Dto/UserSettingsDto";
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  private authUrl = `${environment.apiUrl}auth/userSettings`;

  constructor(
    private http: HttpClient,
  ) { }


  save(user: UserSettingsDto): Observable<HttpResponse<ApiResponse<string>>> {
    return this.http.post<ApiResponse<string>>(this.authUrl, user, { observe: 'response' })
      .pipe(
        catchError((error: HttpErrorResponse) => {
          console.log(error);
          return of(new HttpResponse<ApiResponse<string>>({ status: error.status, body: { Message: error.message } }));
        }),
        map((response) => {
          return response;
        })
      );
  }
}
