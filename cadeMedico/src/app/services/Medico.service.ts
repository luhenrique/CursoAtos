import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import{ Medico } from '../models/Medico';

@Injectable({
  providedIn: 'root'
})
export class MedicoService {
  

  baseURL = `${environment.mainUrlApi}medico`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Medico[]>{
    return this.http.get<Medico[]>(this.baseURL);
  }

  getById(id: number): Observable<Medico>{
    return this.http.get<Medico>(`${this.baseURL}/${id}`);
  }
  
  getByEspecialidade(id: number): Observable<Medico[]>{
    return this.http.get<Medico[]>(`${this.baseURL}/especialidade/${id}`);
  }

  add(medico: Medico){
    return this.http.post(this.baseURL, medico);
  }

  edit(medico: Medico){
    return this.http.put(`${this.baseURL}/${medico.id}`, medico);
  }

  delete(id: number){
    return this.http.delete(`${this.baseURL}/${id}`);
  }



}
