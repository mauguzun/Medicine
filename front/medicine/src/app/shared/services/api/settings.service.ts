import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/assets/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  private authUrl = `${environment.apiUrl}auth`;

  constructor(
    private http: HttpClient,
  ) { }


  
}
