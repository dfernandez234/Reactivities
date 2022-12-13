import { Profile } from "./profile";

export interface IActivity{
    activityId: string;
    title: string;
    date: string;
    description: string;
    category: string;
    city: string;
    venue: string;
    hostUsername?: string;
    isCancelled: boolean;
    isGoing?: boolean;
    isHost?: boolean;
    host?: Profile;
    attendees: Profile[]
}

export class ActivityFormValues{
    
    ActivityId?: string = '';
    title: string = '';
    category: string = '';
    description: string = '';
    date: string = '';
    city: string = '';
    venue: string = '';

    constructor(activity?: ActivityFormValues){
        if(activity){
            this.ActivityId = activity.ActivityId;
            this.title = activity.title;
            this.category = activity.category;
            this.description = activity.description;
            this.date = activity.date;
            this.venue = activity.venue;
            this.city = activity.city
        }
    }
}

export class EditActivityFormValues{
    id:string = ''
    title: string = '';
    category: string = '';
    description: string = '';
    date: string = '';
    city: string = '';
    venue: string = '';

    constructor(activity?: EditActivityFormValues){
        if(activity){
            this.id = '';
            this.title = activity.title;
            this.category = activity.category;
            this.description = activity.description;
            this.date = activity.date;
            this.venue = activity.venue;
            this.city = activity.city
        }
    }
}