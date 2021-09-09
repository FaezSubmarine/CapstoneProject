using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using CapstoneProject.Repository;
using CapstoneProject.Data;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.Repository
{
    public class RaceRecordRepository : IRecordRepository
    {
        RaceContext raceContext { get; }

        public RaceRecordRepository(RaceContext raceContext)
        {
            this.raceContext = raceContext;
        }
        public bool CreateRequest(RaceRequest record)
        {
            record.circuit = Getcircuit(record.circuitID);
            raceContext.raceRequestLists.Add(record);
            raceContext.SaveChanges();
            return true;
        }

        public bool DeleteRecord(RaceRecords record)
        {
            raceContext.raceRecordLists.Remove(record);
            raceContext.SaveChanges();

            return true;
        }

        public List<RaceRecords> GetRaceRecords()
        {
            return raceContext.raceRecordLists.Include(e => e.circuit).ToList().Where(e => !(e is RaceRequest)).ToList();
        }
        public List<RaceRequest> GetRequestRecords()
        {
            return raceContext.raceRequestLists.Include(e => e.circuit).ToList().Where(e => e is RaceRequest).ToList();
        }

        public RaceRecords GetRecord(int id)
        {
            return raceContext.raceRecordLists.FirstOrDefault(rec => rec.id == id);
        }
        public RaceRequest GetRequest(int id)
        {
            return raceContext.raceRequestLists.FirstOrDefault(rec => rec.id == id);
        }
        public bool UpdateRecord(RaceRecords record)
        {
            throw new NotImplementedException();
        }
        public List<circuit> getCircuits()
        {
            return raceContext.circuitList.ToList();
        }

        public bool CreateCircuit(circuit circuit)
        {
            raceContext.circuitList.Add(circuit);
            raceContext.SaveChanges();
            return true;
        }

        public bool deleteCircuit(circuit circuit)
        {
            raceContext.circuitList.Remove(circuit);
            raceContext.SaveChanges();

            return true;
        }
        public circuit Getcircuit(int id)
        {
            return raceContext.circuitList.FirstOrDefault(rec => rec.id == id);
        }

        public bool DeleteRequest(RaceRequest record)
        {
            raceContext.raceRequestLists.Remove(record);
            raceContext.raceRecordLists.Remove(record);
            raceContext.SaveChanges();

            return true;
        }

        public bool changeStatus(int id,RequestStatus requestStatus)
        {
            RaceRequest raceRequest = GetRequest(id);
            raceRequest.requestStatus = requestStatus;
            raceContext.SaveChanges();
            return true;
        }

        public bool RequestToRecordList(RaceRecords record)
        {
            raceContext.raceRecordLists.Add(record);
            record.id = raceContext.raceRecordLists.ToList().Count + 1;
            raceContext.SaveChanges();
            return true;
        }

        public bool addTime(int id, string timing)
        {
            RaceRequest raceRequest = GetRequest(id);
            raceRequest.timing = timing;
            raceContext.SaveChanges();
            return true;
        }
    }
}
