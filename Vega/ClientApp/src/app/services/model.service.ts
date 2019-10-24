import { Model } from 'src/app/models/model';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ModelService {
  constructor(private http: HttpClient) {}

  getModels(id: number) {
    return this.http.get<Model[]>(`${environment.baseUrl}/models/${id}`);
  }
}
