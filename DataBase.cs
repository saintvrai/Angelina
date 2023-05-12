using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UI.Data;

namespace UI
{
    public static class DataBase
    {
        public static List<Project> GetProjects()
        {
            using (DataContext db = new DataContext())
            {
                return db.Projects.OrderByDescending(p => p.ProjectId).ToList();
            }
        }

        public static Project CreateProject(string Name)
        {
            using (DataContext db = new DataContext())
            {
                Project p = db.Projects.Add(new Project() { 
                    Name = Name,
                    ExternalEffect = new ExternalEffect(),
                    FirstDevice = new ElectricDevice(),
                    SecondDevice = new ElectricDevice(),
                    Experiment = new Experiment(),
                    Line = new Line()
                });
                db.SaveChanges();
                return p;
            }
        }

        public static Project GetProject(int id)
        {
            using (DataContext db = new DataContext())
            {
                Project project = db.Projects.Where(p => p.ProjectId == id)
                    .Include(p => p.Line)
                    .Include(p => p.FirstDevice)
                    .Include(p => p.SecondDevice)
                    .Include(p => p.Experiment)
                    .Include(p => p.ExternalEffect)
                    .Include(p => p.Result)
                    .FirstOrDefault();

                return project;
            }
        }
        public static Project EditProject(Project project)
        {
            using (DataContext db = new DataContext())
            {
                Project newP = GetProject(project.ProjectId);

                newP.Name = project.Name;
                newP.FirstDeviceId = project.FirstDeviceId;
                newP.SecondDeviceId = project.SecondDeviceId;
                newP.ExperimentId = project.ExperimentId;
                newP.ResultId = project.ResultId;
                newP.LineId = project.LineId;
                newP.EffectId = project.EffectId;

                db.Entry(newP).State = EntityState.Modified;
                db.SaveChanges();
                return newP;
            }
        }
        public static void DeleteProject(int id)
        {
            using (DataContext db = new DataContext())
            {
                Project p = GetProject(id);

                db.Projects.Attach(p);
                db.Projects.Remove(p);
                db.SaveChanges();
            }
        }

        public static Line EditLine(Line line)
        {
            using (DataContext db = new DataContext())
            {
                Line newL = db.Lines.Where(l => l.LineId == line.LineId).FirstOrDefault();

                newL.BodyMaterialResistance = line.BodyMaterialResistance;
                newL.ConductorRadius = line.ConductorRadius;
                newL.InsulationRadius = line.InsulationRadius;
                newL.X1max = line.X1max;   
                newL.X2min = line.X2min;

                db.Entry(newL).State = EntityState.Modified;
                db.SaveChanges();
                return newL;
            }
        }

        public static ElectricDevice EditDevice(ElectricDevice device)
        {
            using (DataContext db = new DataContext())
            {
                ElectricDevice newD = db.ElectricDevices.Where(d => d.DeviceId == device.DeviceId).FirstOrDefault();

                newD.X0 = device.X0;
                newD.Y0 = device.Y0;
                newD.Z0 = device.Z0;
                newD.X1 = device.X1;
                newD.Y1 = device.Y1;
                newD.Z1 = device.Z1;

                db.Entry(newD).State = EntityState.Modified;
                db.SaveChanges();
                return newD;
            }
        }

        public static ExternalEffect EditEffect(ExternalEffect effect)
        {
            using (DataContext db = new DataContext())
            {
                ExternalEffect newE = db.ExternalEffects.Where(e => e.EffectId == effect.EffectId).FirstOrDefault();

                newE.EffectId = effect.EffectId;
                newE.FieldStrength = effect.FieldStrength;
                newE.ImpulseDuration = effect.ImpulseDuration;
                newE.ImpulseAmp = effect.ImpulseAmp;
                newE.ImpulseStrength = effect.ImpulseStrength;
                newE.IncreaseTime = effect.IncreaseTime;
                newE.DecreaseTime = effect.DecreaseTime;
                newE.Duration = effect.Duration;
                newE.Frequency = effect.Frequency;

                db.Entry(newE).State = EntityState.Modified;
                db.SaveChanges();
                return newE;
            }
        }

        public static Experiment EditExperiment(Experiment experiment)
        {
            using (DataContext db = new DataContext())
            {
                Experiment newE = db.Experiments.Where(e => e.ExperimentId == experiment.ExperimentId).FirstOrDefault();

                newE.MaxFrequency = experiment.MaxFrequency;
                newE.SourceX = experiment.SourceX;
                newE.SourceY = experiment.SourceY;
                newE.SourceZ = experiment.SourceZ;
                newE.VectorX = experiment.VectorX;
                newE.VectorY = experiment.VectorY;
                newE.VectorZ = experiment.VectorZ;

                db.Entry(newE).State = EntityState.Modified;
                db.SaveChanges();
                return newE;
            }
        }
    }
}
