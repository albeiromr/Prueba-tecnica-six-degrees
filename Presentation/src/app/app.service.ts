import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiResponseModel } from './models/api-response.model';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  private _httpClient = inject(HttpClient);

  constructor() { }

  /**
   * fetch and returns the users data from the server
   */
  public getServerData(): Observable<ApiResponseModel> {
    return this._httpClient.get<ApiResponseModel>("http://localhost:5291/api/users");
  }
}
