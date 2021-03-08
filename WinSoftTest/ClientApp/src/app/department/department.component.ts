import { Component, OnInit } from '@angular/core';
import { DepartmentModel } from '../models/department.model';
import { EmployeeModel } from '../models/employee.model';
import { DepartmentService } from '../service/department.service';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css'],
  providers: [DepartmentService]
})
export class DepartmentComponent implements OnInit {
  deptList: DepartmentModel[] = [];
  empList: EmployeeModel[] = [];

  constructor(private deptService: DepartmentService) { }

  ngOnInit() {
    this.getAllDepartments();
  }

  getAllDepartments() {
    this.deptService.getAllDepartments().subscribe(data => {
      this.deptList = data;
    }, error => {
      console.log(error);
    });
  }
  
  getEmployees(deptId: number) {
    this.deptService.getDepartmentwiseEmployees(deptId).subscribe(data => {
      this.empList = data;
    }, error => {
      console.log(error);
    });
  }
}
