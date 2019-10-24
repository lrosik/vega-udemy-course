import { Feature } from './../models/feature';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {
  constructor(private http: HttpClient) {}

  getFeatures() {
    return this.http.get<Feature[]>(`${environment.baseUrl}/features`);
  }
}
