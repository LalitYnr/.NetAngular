import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class AuthService {
  constructor(private http: HttpClient) {}
  login(data: any) { return this.http.post('/api/v1/auth/login', data); }
  register(data: any) { return this.http.post('/api/v1/auth/register', data); }
}
