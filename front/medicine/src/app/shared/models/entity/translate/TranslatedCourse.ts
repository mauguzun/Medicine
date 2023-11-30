import { Language } from "../../../enums/Language";
import { User } from "../User";
import { Course } from "../Course";


export class TranslatedCourse {
  courseId!: number;
  course!: Course;
  version?: string;
  title?: string;
  description?: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
