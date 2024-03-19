import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiDogService {

  constructor(private http: HttpClient) { }

  getRandomDogImage(): Observable<string> {
    return this.http.get<{ message: string, status: string }>('https://dog.ceo/api/breeds/image/random')
      .pipe(map(response => response.message)
      );
  }
}
