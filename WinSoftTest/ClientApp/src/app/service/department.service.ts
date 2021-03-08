import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { DepartmentModel } from '../models/department.model';
import { EmployeeModel } from '../models/employee.model';

@Injectable()
export class DepartmentService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getAllDepartments(){
    return this.http.get<DepartmentModel[]>(this.baseUrl + 'api/Employees/getalldepartments');
  }

  getDepartmentwiseEmployees(deptId: number){
    return this.http.get<EmployeeModel[]>(this.baseUrl + 'api/Employees/getdepartmentwiseemployees/' + deptId);
  }
}
