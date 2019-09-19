import { Make } from './../models/make';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MakeService {
  constructor(private http: HttpClient) {}

  getMakes() {
    return this.http.get<Make[]>(environment.baseUrl + '/makes');
  }
}
