import { Sex } from "../../enums/Sex";
import { User } from "./User";
import { Course } from "./Course";

export class CourseSettings {
  courseId!: number;
  course!: Course;
  sex!: Sex;
  minAge?: number;
  maxAge?: number;
  weight!: number;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}

