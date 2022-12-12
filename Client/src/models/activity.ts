import { Profile } from "./profilte";

export interface IActivity{
    activityId: string;
    title: string;
    date: string;
    description: string;
    category: string;
    city: string;
    venue: string;
    hostUsername?: string;
    isCancelled?: boolean;
    isGoing?: boolean;
    isHost?: boolean;
    host?: Profile;
    attendees: Profile[]
}