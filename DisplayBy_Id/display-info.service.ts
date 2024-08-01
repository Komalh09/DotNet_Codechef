import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { catchError, Observable, retry, throwError } from 'rxjs';
import { DisplayInfo } from './display-info';


@Injectable({
  providedIn: 'root'
})
export class DisplayInfoService {
  apiUrl = 'http://localhost:3000/info';  // Base API URL

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  }

  // Fetch all records
  getInfo(): Observable<DisplayInfo[]> {
    return this.http.get<DisplayInfo[]>(this.apiUrl, this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.handleError)
      );
  }

  // Fetch a specific record by ID
  getDataById(id: number): Observable<DisplayInfo> {
    return this.http.get<DisplayInfo>(`${this.apiUrl}/${id}`, this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.handleError)
      );
  }

 // Error handling
 handleError(error: { error: { message: string; }; status: any; message: any; }) {
  let errorMessage = '';
  if (error.error instanceof HttpErrorResponse) {
    // Client-side error
    errorMessage = error.error.message;
  } else {
    // Server-side error
    errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
  }
  window.alert(errorMessage);
  return throwError(errorMessage);
}
}

