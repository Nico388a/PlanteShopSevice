using System;
using System.Collections.Generic;
using System.Text;

namespace Plante.Model
{
   public class PlanteModel
    {
        private int _plantId;
        private string _plantType;
        private string _plantName;
        private double _price;
        private double _maxHigh;


        public int PlantId
        {
            get => _plantId;
            set => _plantId = value;
        }


        public string PlantType
        {
            get => _plantType;
            set => _plantType = value;
        }


        public string PlanteNavn
        {
            get => _plantName;
            set => _plantName = value;
        }


        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public double MaxHigh
        {
            get => _maxHigh;
            set => _maxHigh = value;
        }

        public PlanteModel(int plantId, string plantType, string plantName, double price, double maxHigh)
        {
            _plantId = plantId;
            _plantType = plantType;
            _plantName = plantName;
            _price = price;
            _maxHigh = maxHigh;
        }

        public PlanteModel()
        {

        }

        public override string ToString()
        {
            return PlantId + "" + PlantType + "" + PlanteNavn + "" + Price + "" + MaxHigh;
        }
    }
}
